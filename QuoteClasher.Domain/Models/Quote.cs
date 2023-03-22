namespace QuoteClasher.Domain.Models
{
    public class Quote
    {
        public Quote(string content, string quotee)
        {
            Content = content;
            Quotee = quotee;
        }
        public string Content { get; set; }
        public string Quotee { get; set; }

    }
}