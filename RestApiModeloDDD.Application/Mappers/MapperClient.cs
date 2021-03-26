using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces.Mappers;
using RestApiModeloDDD.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModeloDDD.Application.Mappers
{
    public class MapperClient : IMapperClient
    {
        IEnumerable<ClientDTO> clientDTO = new List<ClientDTO>();

        public Client MapperDTOToEntity(ClientDTO clientDTO)
        {
            var clients = new Client()
            {
                Id = clientDTO.Id
                ,
                Name = clientDTO.Name
                ,
                Lastname = clientDTO.Lastname
                ,
                Email = clientDTO.Email
            };

            return clients;
        }

        public ClientDTO MapperEntityToDTO(Client client)
        {
            var clientDTO = new ClientDTO()
            {
                Id = client.Id
                ,
                Name = client.Name
                ,
                Lastname = client.Lastname
                ,
                Email = client.Email
            };

            return clientDTO;
        }

        public IEnumerable<ClientDTO> MapperListClientsDTO(IEnumerable<Client> clients)
        {
            var dto = clients.Select(c =>
                new ClientDTO
                {
                    Id = c.Id
                    ,
                    Name = c.Name
                    ,
                    Lastname = c.Lastname
                    ,
                    Email = c.Email
                }
            );

            return dto;
        }
    }
}
