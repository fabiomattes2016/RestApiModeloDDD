using RestApiModeloDDD.Application.Dtos;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application.Interfaces
{
    public interface IApplicationServiceProduct
    {
        void Add(ProductDTO productDTO);
        void Update(ProductDTO productDTO);
        void Remove(ProductDTO productDTO);
        IEnumerable<ProductDTO> Getall();
        ProductDTO GetById(int id);
    }
}
