

using QuoteClasher.DataAccess.DataRequestObjects.Quotes;
using QuoteClasher.DataAccess.Tests.TestHelpers;

namespace QuoteClasher.DataAccess.Tests.DataRequestTests.Quotes
{
    public class DeleteQuoteTest: DataTest
    {
        [Fact]
        public async Task Delete_Quote_Given_QuoteIsDeleted_Should_ReturnOne()
        {
            await _dataAccess.ExecuteAsync(_requestBuilder.InsertQuoteRequest(TestGuid, "DeleteQuoteReturnsOne"));

            var result = await _dataAccess.ExecuteAsync(new DeleteQuote(TestGuid));

            Assert.Equal(1, result);
        }

        public async Task Delete_Quote_Given_QuoteDoesNotExist_Should_ReturnZero()
        {
            var result = await _dataAccess.ExecuteAsync(new DeleteQuote(TestGuid));

            Assert.Equal(0, result);
        }

    }
}
