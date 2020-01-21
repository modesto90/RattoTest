using Ratto.Domain.Entities;
using Ratto.Domain.Interfaces.Repositories;
using Ratto.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ratto.Domain.ServicesDomain
{
    public class EnderecoService: IEnderecoService
    {
        private readonly IRepositoryEndereco _enderecoRepository;
        public EnderecoService(IRepositoryEndereco enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }

        public void ExcluirEndereco(int id)
        {
            Endereco end = this.Obter(id);

            _enderecoRepository.Remove(end);
        }

        public Endereco AdicionarEndereco(string logradouro,
            string bairro, string cidade, string estado)
        {
            Endereco end = new Endereco(logradouro, bairro, cidade, estado);
            _enderecoRepository.Add(end);
            return end;
        }

        public Endereco AtualizarEndereco(int Id, string Logradouro, string Bairro, string Cidade, string Estado)
        {
            Endereco end = this.Obter(Id);

            end.Logradouro.setValor(Logradouro, "logradouro", 50);
            end.Bairro.setValor(Bairro, "bairro", 40);
            end.Cidade.setValor(Cidade, "cidade", 40);
            end.Estado.setValor(Estado, "estado", 40);

            _enderecoRepository.Update(end);
            return end;
        }

        public Endereco Obter(int Id)
        {
            Endereco end = _enderecoRepository.GetById(Id);

            if (end == null)
                throw new ArgumentException("Endereço não encontrado");

            return end;

        }
    }
}
