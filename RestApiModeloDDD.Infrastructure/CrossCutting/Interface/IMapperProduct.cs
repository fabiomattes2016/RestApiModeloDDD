using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace RestApiModeloDDD.Infrastructure.CrossCutting.Interface
{
    public interface IMapperProduct
    {
        Product MapperDTOToEntity(ProductDTO productDTO);
        IEnumerable<ProductDTO> MapperListProductsDTO(IEnumerable<Product> products);
        ProductDTO MapperEntityToDTO(Product product);
    }
}
