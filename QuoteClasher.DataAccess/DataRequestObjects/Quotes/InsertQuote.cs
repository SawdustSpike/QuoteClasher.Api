using QuoteClasher.DataAccess.Abstraction;
using QuoteClasher.DataAccess.Abstraction.BaseRequests;
using QuoteClasher.IDataRequest.DataTransferObjects;

namespace QuoteClasher.IDataRequest.DataRequestObjects.Quotes
{
    public class InsertQuote : GuidRequest
    {
        public InsertQuote(Guid guid, string content, string quotee) : base(guid)
        {            
            Content = content;
            Quotee = quotee;            
        }

       
        public string Content { get; set; }
        public string Quotee { get; set; }
        
        public override object? GetParameters() => new { Guid, Content, Quotee};
        public override string GetSql() => @"INSERT INTO Quote (Guid, Content, Quotee) VALUES (@Guid, @Content, @Quotee);";

      
    }
}
