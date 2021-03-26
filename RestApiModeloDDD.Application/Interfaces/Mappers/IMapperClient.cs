using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application.Interfaces.Mappers
{
    public interface IMapperClient
    {
        Client MapperDTOToEntity(ClientDTO clientDTO);
        IEnumerable<ClientDTO> MapperListClientsDTO(IEnumerable<Client> clients);
        ClientDTO MapperEntityToDTO(Client client);
    }
}
