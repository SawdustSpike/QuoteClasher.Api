using QuoteClasher.DataAccess.DataRequestObjects.Quotes;
using QuoteClasher.DataAccess.Tests.TestHelpers;
using QuoteClasher.IDataRequest.DataRequestObjects.Quotes;


namespace QuoteClasher.IDataRequest.Tests.DataRequestTests.Quotes
{
    public class GetQuoteTests: DataTest
    {
       

        [Fact]
        public async Task GetQuote_NoQuoteExists_Should_ReturnFalse()
        {           

            Assert.Null(await _dataAccess.FetchAsync(new GetQuote(TestGuid)));
        }

        [Fact]
        public async Task GetQuote_Given_QuoteExists_Should_ReturnQuote()
        {
            var quoteInserted = _requestBuilder.InsertQuoteRequest(TestGuid, "GetQuoteReturnsValue");
            

            await _dataAccess.ExecuteAsync(quoteInserted);

            var resultFetched = await _dataAccess.FetchAsync(new GetQuote(TestGuid));

            await _dataAccess.ExecuteAsync(new DeleteQuote(TestGuid));

            Assert.Multiple(()=>
            {
                Assert.NotNull(resultFetched);

                Assert.Equal(quoteInserted.Guid, resultFetched.Guid);
                Assert.Equal(quoteInserted.Content, resultFetched.Content);
                Assert.Equal(quoteInserted.Quotee, resultFetched.Quotee);
                //Assert.Equal(quoteInserted.DateAdded, resultFetched.DateAdded);
            });

        }
    }
}

