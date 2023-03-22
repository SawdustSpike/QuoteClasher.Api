

namespace QuoteClasher.IDataRequest.DataTransferObjects
{
    public class QuoteDTO
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public string Content { get; set; }
        public string Quotee { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
