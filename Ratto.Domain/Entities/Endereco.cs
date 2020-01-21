using Ratto.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ratto.Domain.Entities
{
    public class Endereco
    {
        public int Id { get; set; }
        public EnderecoInfo Logradouro { get; private set; }
        public EnderecoInfo Bairro { get; private set; }
        public EnderecoInfo Cidade { get; private set; }
        public EnderecoInfo Estado { get; private set; }

        public Endereco()
        {

        }
        public Endereco(string logradouro,
            string bairro,
            string cidade,
            string estado)
        {
            this.Logradouro = new EnderecoInfo(logradouro, "logradouro", 50);
            this.Bairro = new EnderecoInfo(bairro, "bairro",40);
            this.Cidade = new EnderecoInfo(cidade, "cidade", 40);
            this.Estado = new EnderecoInfo(estado, "estado", 40);

        }
       
    }
}
