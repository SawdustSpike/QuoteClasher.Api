using QuoteClasher.DataAccess.Abstraction;
using QuoteClasher.IDataRequest.DataTransferObjects;

namespace QuoteClasher.IDataRequest.DataRequestObjects.Quotes
{
    public class GetAllQuotesByQuotee: IDataRequest<QuoteDTO>
    {

        public GetAllQuotesByQuotee(string quotee) => Quotee = quotee;


        public string Quotee { get; set; }

            public object? GetParameters() => new { Quotee };
            public string GetSql() => "SELECT * FROM Quote WHERE Quotee = @Quotee";
       
    }
}
