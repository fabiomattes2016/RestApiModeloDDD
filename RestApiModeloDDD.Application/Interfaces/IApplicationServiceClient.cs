using RestApiModeloDDD.Application.Dtos;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application.Interfaces
{
    public interface IApplicationServiceClient
    {
        void Add(ClientDTO clientDTO);
        void Update(ClientDTO clientDTO);
        void Remove(ClientDTO clientDTO);
        IEnumerable<ClientDTO> Getall();
        ClientDTO GetById(int id);
    }
}
