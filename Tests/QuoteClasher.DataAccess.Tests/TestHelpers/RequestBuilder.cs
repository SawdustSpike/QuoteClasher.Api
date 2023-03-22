

using QuoteClasher.IDataRequest.DataRequestObjects.Quotes;

namespace QuoteClasher.DataAccess.Tests.TestHelpers
{
    public class RequestBuilder
    {
        public InsertQuote InsertQuoteRequest(Guid guid, string content = "content", string quotee = "quotee") => 
            new InsertQuote(guid, content, quotee);
    }
}
