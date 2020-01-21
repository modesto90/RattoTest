using Ratto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ratto.Domain.Interfaces.Services
{
    public interface IClienteService
    {
        Cliente AdicionarCliente(string nome, string cpf, string dataDeNascimento);
        void ExcluirCliente(int id);
        Cliente Obter(int id);
        Cliente AtualizarCliente(int id, string nome, string cpf, string idade);
    }
}
