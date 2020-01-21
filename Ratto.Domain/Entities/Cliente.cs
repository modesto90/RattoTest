using Ratto.Domain.Enums;
using Ratto.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ratto.Domain.Entities
{
    public class Cliente
    {
        public int Id { get; private set; }

        public Document Cpf { get; private set; }

        public string  Nome { get; private set; }

        public string  Idade { get; private set; }

        public Cliente()
        {

        }

        public void setCpf(string numero)
        {
            this.Cpf.setCpf(numero);
        }
        public Cliente(string cpf, string nome, string idade)
        {

            Cpf = new Document(cpf, DocumentTypeEnum.CPF);
            setIdade(idade);
            setNome(nome);
        }

        public void setIdade(string idade)
        {
            if (string.IsNullOrEmpty(idade))
                throw new ArgumentException("Idade é obrigatório");

            Idade = idade;
        }

        public void setNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("Nome do cliente é obrigatório");
            else if (nome.Length > 30)
                throw new ArgumentException("Nome excedeu o limite de 30 caracteres");

            this.Nome = nome;
        
        }

    }
}
