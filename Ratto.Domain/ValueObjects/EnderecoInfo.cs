using System;
using System.Collections.Generic;
using System.Text;

namespace Ratto.Domain.ValueObjects
{
    public class EnderecoInfo
    {
        public string Valor { get; private set; }

        public EnderecoInfo()
        {

        }

        public void setValor(string valor, string campoNome, int maxCaracteres)
        {
            if (string.IsNullOrEmpty(valor) || valor.Length > maxCaracteres)
                throw new ArgumentException(string.Format("{0}{1}{2}", campoNome, " é obrigatório e no máximo ", maxCaracteres + " caracteres"));


            this.Valor = valor;
        }

        public EnderecoInfo(string valor, string campoNome, int maxCaracteres)
        {
            setValor(valor, campoNome, maxCaracteres);

        }
    }
}
