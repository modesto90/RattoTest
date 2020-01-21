using System;
using System.Collections.Generic;
using System.Text;

namespace Ratto.Application.Dtos
{
    public class EnderecoDTO
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public EnderecoDTO(int id, string logradouro, string bairro, string cidade, string estado)
        {
            Id = id;
            Logradouro = logradouro;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }
    }
}
