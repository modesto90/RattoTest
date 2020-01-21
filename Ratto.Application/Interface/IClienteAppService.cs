using Ratto.Application.Dtos;
using Ratto.Application.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ratto.Application.Interface
{
    public interface IClienteAppService
    {
        RetornoPadraoDTO AdicionarCliente(AdicionarClienteDTO request);
        RetornoPadraoDTO ObterTodos();
        RetornoPadraoDTO Obter(int id);
        RetornoPadraoDTO ExcluirCliente(int id);
        RetornoPadraoDTO AtualizarCliente(ClienteDTO cliente);

    }
}
