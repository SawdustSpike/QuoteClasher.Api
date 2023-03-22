using QuoteClasher.DataAccess.Abstraction;

namespace QuoteClasher.IDataRequest.Implementation
{
    public static class DataAccessFactory
    {
        public static IDataAccess NewDataAccess(string connectionString) => new DataAccess(new DbConnectionFactory(connectionString));

    }
}
