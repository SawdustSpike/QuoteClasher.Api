

using QuoteClasher.DataAccess.Abstraction;
using QuoteClasher.DataAccess.Abstraction.BaseRequests;
using QuoteClasher.IDataRequest.DataTransferObjects;

namespace QuoteClasher.DataAccess.DataRequestObjects.Quotes
{
    public class DeleteQuote : GuidRequest
    {
        public DeleteQuote(Guid guid) : base(guid) { }


        public override string GetSql() => "DELETE FROM Quote WHERE Guid = @Guid;";
    }
}
