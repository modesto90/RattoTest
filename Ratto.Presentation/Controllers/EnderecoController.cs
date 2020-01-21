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
    public class EnderecoController : ControllerBase
    {
        protected readonly IEnderecoAppService _enderecoAppService;
        public EnderecoController(IEnderecoAppService enderecoAppService)
        {
            _enderecoAppService = enderecoAppService;
        }


        [HttpPost("AdicionarEndereco")]
        public ActionResult AdicionarCliente([FromBody]EnderecoDTO request)
        {
            return Ok(_enderecoAppService.AdicionarEndereco(request));
        }

        [HttpPost("ExcluirEndereco")]
        public ActionResult ExcluirCliente(int id)
        {
            return Ok(_enderecoAppService.ExcluirEndereco(id));
        }



        [HttpGet("Obter")]
        public ActionResult Obter(int id)
        {
            return Ok(_enderecoAppService.Obter(id));
        }

        [HttpGet("ObterTodos")]
        public ActionResult ObterTodos()
        {
            return Ok(_enderecoAppService.ObterTodos());
        }

        [HttpPut("AtualizarEndereco")]
        public ActionResult AtualizarCliente([FromBody] EnderecoDTO request)
        {
            return Ok(_enderecoAppService.AtualizarEndereco(request));
        }
    }
}