using Ratto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ratto.Domain.Interfaces.Services
{
    public interface IEnderecoService
    {
        Endereco AtualizarEndereco(int Id, string Logradouro, string Bairro, string Cidade, string Estado);
        Endereco AdicionarEndereco(string Logradouro, string Bairro, string Cidade, string Estado);
        Endereco Obter(int Id);
        void ExcluirEndereco(int id);
    }
}
