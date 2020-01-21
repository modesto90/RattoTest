using Ratto.Application.Dtos;
using Ratto.Application.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ratto.Application.Interface
{
    public interface IEnderecoAppService
    {
        RetornoPadraoDTO ExcluirEndereco(int id);
        RetornoPadraoDTO AdicionarEndereco(EnderecoDTO request);
        RetornoPadraoDTO AtualizarEndereco(EnderecoDTO request);
        RetornoPadraoDTO Obter(int id);
        RetornoPadraoDTO ObterTodos();
    }
}
