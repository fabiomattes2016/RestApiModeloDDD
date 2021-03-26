using Microsoft.AspNetCore.Mvc;
using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace RestApiModeloDDD.API.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {

        private readonly IApplicationServiceClient _applicationServiceClient;

        public ClientController(IApplicationServiceClient ApplicationServiceClient)
        {
            _applicationServiceClient = ApplicationServiceClient;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceClient.Getall());
        }

        // api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceClient.GetById(id));
        }

        // api/values
        [HttpPost]
        public ActionResult Post([FromBody] ClientDTO clientDTO)
        {
            try
            {
                if (clientDTO == null)
                    return NotFound();

                _applicationServiceClient.Add(clientDTO);

                return Ok("Cliente Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] ClientDTO clientDTO)
        {
            try
            {
                if (clientDTO == null)
                    return NotFound();

                _applicationServiceClient.Update(clientDTO);

                return Ok("Cliente Atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // api/values/5
        [HttpDelete]
        public ActionResult Delete([FromBody] ClientDTO clientDTO)
        {
            try
            {
                if (clientDTO == null)
                    return NotFound();

                _applicationServiceClient.Remove(clientDTO);

                return Ok("Cliente Excluído com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
