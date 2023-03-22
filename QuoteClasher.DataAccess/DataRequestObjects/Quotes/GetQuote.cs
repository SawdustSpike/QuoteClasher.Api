
using QuoteClasher.DataAccess.Abstraction.BaseRequests;
using QuoteClasher.IDataRequest.DataTransferObjects;

namespace QuoteClasher.IDataRequest.DataRequestObjects.Quotes
{

    public class GetQuote : GuidRequest<QuoteDTO>
    {
        public GetQuote(Guid guid) : base(guid) { }     
        
        public object? GetParameters() => new { Guid };

        public override string GetSql() => "SELECT * FROM Quote WHERE Guid = @Guid";
    }
}
