using QuoteClasher.DataAccess.DataRequestObjects.Quotes;
using QuoteClasher.DataAccess.Tests.TestHelpers;
using QuoteClasher.IDataRequest.DataRequestObjects.Quotes;
using System.Data.SqlClient;

namespace QuoteClasher.DataAccess.Tests.DataRequestTests.Quotes
{
    public class InsertQuoteTests : DataTest
    {
        [Fact]
        public async Task InsertQuote_Given_QuoteIsInserted_Should_ReturnOne()
        {       
            var rowsAffected = await _dataAccess.ExecuteAsync(_requestBuilder.InsertQuoteRequest(TestGuid, "InsertReturnsOne"));

            await _dataAccess.ExecuteAsync(new DeleteQuote(TestGuid));

            Assert.Equal(1, rowsAffected);
        }

        [Fact]
        public async Task InsertQuote_Given_GuidIsTaken_Should_ThrowSqlExeception()
        {
            var insertRequest = _requestBuilder.InsertQuoteRequest(TestGuid, "OnlyOneQuoteGuidAllowed");

            await _dataAccess.ExecuteAsync(insertRequest);

            insertRequest.Quotee = "New Quotee";

            var exception = await Record.ExceptionAsync(async()=> await _dataAccess.ExecuteAsync(insertRequest));

            await _dataAccess.ExecuteAsync(new DeleteQuote(TestGuid));

            Assert.IsType<SqlException>(exception);
        }

        //[Fact]
        //public async Task InsertQuote_Given_ContentIsTaken_Should_ThrowSqlExeception()
        //{
        //    var insertRequest = _requestBuilder.InsertQuoteRequest(TestGuid, "OnlyOneQuoteAllowed");

        //    await _dataAccess.ExecuteAsync(insertRequest);

        //    insertRequest.Guid = Guid.NewGuid();

        //    var exception = await Record.ExceptionAsync(async () => await _dataAccess.ExecuteAsync(insertRequest));

        //    await _dataAccess.ExecuteAsync(new DeleteQuote(TestGuid));

        //    Assert.IsType<SqlException>(exception);
        //}
    }
}
