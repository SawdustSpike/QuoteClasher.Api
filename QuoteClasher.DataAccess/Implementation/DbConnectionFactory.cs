

using System.Data;
using System.Data.SqlClient;
using QuoteClasher.DataAccess.Abstraction;

namespace QuoteClasher.IDataRequest.Implementation
{
    public class DbConnectionFactory : IDbConnectionFactory
    {
        private readonly string _connectionString;
        public DbConnectionFactory(string connectionString) => _connectionString = connectionString;
        public IDbConnection NewConnection() => new SqlConnection(_connectionString);

    }
}
