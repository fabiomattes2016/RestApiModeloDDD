using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiModeloDDD.Domain.Entities;

namespace RestApiModeloDDD.Domain.Services
{
    public class ServiceClient : ServiceBase<Client>, IServiceClient
    {
        private readonly IRepositoryClient repositoryClient;

        public ServiceClient(IRepositoryClient repositoryClient) : base(repositoryClient)
        {
            this.repositoryClient = repositoryClient;
        }
    }
}
