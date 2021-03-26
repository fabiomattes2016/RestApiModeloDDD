using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces.Mappers;
using RestApiModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestApiModeloDDD.Application.Mappers
{
    class MapperProduct : IMapperProduct
    {
        IEnumerable<ProductDTO> productDTO = new List<ProductDTO>();

        public Product MapperDTOToEntity(ProductDTO productDTO)
        {
            var product = new Product()
            {
                Id = productDTO.Id
                ,
                Name = productDTO.Name
                ,
                Price = productDTO.Price
            };

            return product;
        }

        public ProductDTO MapperEntityToDTO(Product product)
        {
            var productDTO = new ProductDTO()
            {
                Id = product.Id
                ,
                Name = product.Name
                ,
                Price = product.Price
            };

            return productDTO;
        }

        public IEnumerable<ProductDTO> MapperListProductsDTO(IEnumerable<Product> products)
        {
            var dto = products.Select(p =>
                new ProductDTO
                {
                    Id = p.Id
                    ,
                    Name = p.Name
                    ,
                    Price = p.Price
                }
            );

            return dto;
        }
    }
}
