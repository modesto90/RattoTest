using System;
using System.Collections.Generic;
using System.Text;

namespace Ratto.Application.Dtos
{
    public class ClienteDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Idade { get; set; }

        public ClienteDTO(int id, string nome, string cpf, string idade)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cpf = cpf;
            this.Idade = idade;
        }
    }
}
