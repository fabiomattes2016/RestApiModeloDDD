using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;
using RestApiModeloDDD.Domain.Entities;

namespace RestApiModeloDDD.Infrastructure.Data.Repositories
{
    public class RepositoryClient : RepositoryBase<Client>, IRepositoryClient
    {
        private readonly SqlContext sqlContext;

        public RepositoryClient(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
