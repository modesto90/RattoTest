using Ratto.Domain.Entities;
using Ratto.Domain.Interfaces.Repositories;
using Ratto.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ratto.Domain.ServicesDomain
{
    public class ClienteService : IClienteService
    {
        private readonly IRepositoryCliente _clienteRepository;
        public ClienteService(IRepositoryCliente clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public void ExcluirCliente(int id)
        {
            Cliente c = _clienteRepository.GetById(id);

            if (c == null)
                throw new ArgumentException("Cliente não encontrado");

            _clienteRepository.Remove(c);

        }

        public Cliente AtualizarCliente(int id, string nome, string cpf, string idade)
        {
            Cliente c = _clienteRepository.GetById(id);

            if (c == null)
                throw new ArgumentException("Cliente não encontrado");

            c.setIdade(idade);
            c.setNome(nome);
            c.setCpf(cpf);

            _clienteRepository.Update(c);

            return c;

        }

        public Cliente Obter(int id)
        {
            return _clienteRepository.GetById(id);
        }

        public Cliente AdicionarCliente(string nome, string cpf, string idade)
        {
            Cliente c = new Cliente(cpf,nome, idade);
            _clienteRepository.Add(c);
            return c;
        }
    }
}
