using QuoteClasher.DataAccess.Abstraction;
using QuoteClasher.IDataRequest.Implementation;
using QuoteClasher.IDataRequest.Tests;

namespace QuoteClasher.DataAccess.Tests.TestHelpers
{
    public class DataTest
    {
        protected readonly IDataAccess _dataAccess;

        protected readonly Guid TestGuid;

        protected readonly RequestBuilder _requestBuilder;

        public DataTest()
        {
            _dataAccess = DataAccessFactory.NewDataAccess(Hidden.TestDbConnectionString);

            TestGuid = Guid.NewGuid();

            _requestBuilder = new RequestBuilder();
        }
    }
}
