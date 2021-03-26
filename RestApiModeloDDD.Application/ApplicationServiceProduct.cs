using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Application.Interfaces.Mappers;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Application
{
    class ApplicationServiceProduct : IApplicationServiceProduct
    {
        private readonly IServiceProduct serviceProduct;
        private readonly IMapperProduct mapperProduct;

        public ApplicationServiceProduct(IServiceProduct serviceProduct, IMapperProduct mapperProduct)
        {
            this.serviceProduct = serviceProduct;
            this.mapperProduct = mapperProduct;
        }

        public void Add(ProductDTO productDTO)
        {
            var product = mapperProduct.MapperDTOToEntity(productDTO);
            serviceProduct.Add(product);
        }

        public IEnumerable<ProductDTO> Getall()
        {
            var products = serviceProduct.GetAll();
            return mapperProduct.MapperListProductsDTO(products);
        }

        public ProductDTO GetById(int id)
        {
            var product = serviceProduct.GetById(id);
            return mapperProduct.MapperEntityToDTO(product);
        }

        public void Remove(ProductDTO productDTO)
        {
            var product = mapperProduct.MapperDTOToEntity(productDTO);
            serviceProduct.Remove(product);
        }

        public void Update(ProductDTO productDTO)
        {
            var product = mapperProduct.MapperDTOToEntity(productDTO);
            serviceProduct.Update(product);
        }
    }
}
