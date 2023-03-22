using System.Data;

namespace QuoteClasher.DataAccess.Abstraction
{
    internal interface IDbConnectionFactory
    {
        public IDbConnection NewConnection();

    }
}
