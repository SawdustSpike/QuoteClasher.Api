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
            DateAdded = DateTime.Now;
        }

       
        public string Content { get; set; }
        public string Quotee { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
        public override object? GetParameters() => new { Guid, Content, Quotee, DateAdded };
        public override string GetSql() => @"INSERT INTO Quote (Guid, Content, Quotee, DateAdded) VALUES (@Guid, @Content, @Quotee, @DateAdded);";

      
    }
}
