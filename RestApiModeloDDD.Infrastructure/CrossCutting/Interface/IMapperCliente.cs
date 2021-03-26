using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace RestApiModeloDDD.Infrastructure.CrossCutting.Interface
{
    public interface IMapperCliente
    {
        Client MapperDTOToEntity(ClientDTO clientDTO);
        IEnumerable<ClientDTO> MapperListClientsDTO(IEnumerable<Client> clients);
        ClientDTO MapperEntityToDTO(Client client);
    }
}
