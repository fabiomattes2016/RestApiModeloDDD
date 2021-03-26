using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Application.Interfaces.Mappers;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application
{
    public class ApplicationServiceClient : IApplicationServiceClient
    {
        private readonly IServiceClient serviceClient;
        private readonly IMapperClient mapperClient;

        public ApplicationServiceClient(IServiceClient serviceClient, IMapperClient mapperClient)
        {
            this.serviceClient = serviceClient;
            this.mapperClient = mapperClient;
        }

        public void Add(ClientDTO clientDTO)
        {
            var client = mapperClient.MapperDTOToEntity(clientDTO);
            serviceClient.Add(client);
        }

        public IEnumerable<ClientDTO> Getall()
        {
            var clients = serviceClient.GetAll();
            return mapperClient.MapperListClientsDTO(clients);
        }

        public ClientDTO GetById(int id)
        {
            var client = serviceClient.GetById(id);
            return mapperClient.MapperEntityToDTO(client);
        }

        public void Remove(ClientDTO clientDTO)
        {
            var client = mapperClient.MapperDTOToEntity(clientDTO);
            serviceClient.Remove(client);
        }

        public void Update(ClientDTO clientDTO)
        {
            var client = mapperClient.MapperDTOToEntity(clientDTO);
            serviceClient.Update(client);
        }
    }
}
