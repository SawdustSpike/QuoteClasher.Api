using Dapper;
using QuoteClasher.DataAccess.Abstraction;

namespace QuoteClasher.IDataRequest.Implementation
{
    internal class DataAccess : IDataAccess
    {
        private readonly IDbConnectionFactory _connectionFactory;

        public DataAccess(IDbConnectionFactory connectionFactory) => _connectionFactory = connectionFactory;

        public async Task<int> ExecuteAsync(QuoteClasher.DataAccess.Abstraction.IDataRequest request)
        {
            using var connection = _connectionFactory.NewConnection();
            connection.Open();
            return await connection.ExecuteAsync(request.GetSql(), request.GetParameters());
        }

        public async Task<TResponse> FetchAsync<TResponse>(IDataRequest<TResponse> request)
        {
            using var connection = _connectionFactory.NewConnection();
            connection.Open();
            return await connection.QueryFirstOrDefaultAsync<TResponse>(request.GetSql(), request.GetParameters());
        }

        public async Task<IEnumerable<TResponse>> FetchListAsync<TResponse>(IDataRequest<TResponse> request)
        {
            using var connection = _connectionFactory.NewConnection();
            connection.Open();
            return await connection.QueryAsync<TResponse>(request.GetSql(), request.GetParameters());
        }
    }
}
