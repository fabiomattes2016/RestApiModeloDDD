using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;
using RestApiModeloDDD.Domain.Entities;

namespace RestApiModeloDDD.Domain.Services
{
    public class ServiceProduct : ServiceBase<Product>, IRepositoryProduct
    {
        private readonly IRepositoryProduct repositoryProduct;

        public ServiceProduct(IRepositoryProduct repositoryProduct) : base(repositoryProduct)
        {
            this.repositoryProduct = repositoryProduct;
        }
    }
}
