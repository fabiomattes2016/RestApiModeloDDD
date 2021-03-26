using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using RestApiModeloDDD.Application.Interfaces.Mappers;

namespace RestApiModeloDDD.Application
{
    public class ApplicationServiceClient : IApplicationServiceClient
    {
        private readonly IServiceClient serviceClient;
        private readonly IMapperClient mapperClient;

        public void Add(ClientDTO clientDTO)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClientDTO> Getall()
        {
            throw new NotImplementedException();
        }

        public ClientDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(ClientDTO clientDTO)
        {
            throw new NotImplementedException();
        }

        public void Update(ClientDTO clientDTO)
        {
            throw new NotImplementedException();
        }
    }
}
