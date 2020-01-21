using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ratto.Application.Dtos;
using Ratto.Application.Interface;

namespace Ratto.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        protected readonly IClienteAppService _clienteAppService;
        public ClienteController(IClienteAppService clienteAppService)
        {
            _clienteAppService = clienteAppService;
        }


        [HttpPost("AdicionarCliente")]
        public ActionResult AdicionarCliente([FromBody]AdicionarClienteDTO request)
        {
            return Ok(_clienteAppService.AdicionarCliente(request));
        }

        [HttpPost("ExcluirCliente")]
        public ActionResult ExcluirCliente(int id)
        {
            return Ok(_clienteAppService.ExcluirCliente(id));
        }



        [HttpGet("Obter")]
        public ActionResult Obter(int id)
        {
            return Ok(_clienteAppService.Obter(id));
        }

        [HttpGet("ObterTodos")]
        public ActionResult ObterTodos()
        {
            return Ok(_clienteAppService.ObterTodos());
        }

        [HttpPut("AtualizarCliente")]
        public ActionResult AtualizarCliente([FromBody] ClienteDTO request)
        {
            return Ok(_clienteAppService.AtualizarCliente(request));
        }
    }
}