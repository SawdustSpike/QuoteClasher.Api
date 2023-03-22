namespace QuoteClasher.DataAccess.Abstraction
{
    public interface IDataAccess
    {
        public Task<int> ExecuteAsync(IDataRequest request);

        public Task<TResponse> FetchAsync<TResponse>(IDataRequest<TResponse> request);
        public Task<IEnumerable<TResponse>> FetchListAsync<TResponse>(IDataRequest<TResponse> request);

    }
}
