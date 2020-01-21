using Ratto.Application.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ratto.Application.DTOS
{
    public class RetornoPadraoDTO
    {
        public string Mensagem { get; set; }
        public ErrorStatusEnum Status { get; set; }
        public dynamic Retorno { get; set; }
        public RetornoPadraoDTO(string mensagem, ErrorStatusEnum status, dynamic retorno = null)
        {
            this.Mensagem = mensagem;
            this.Status = status;
            this.Retorno = retorno;
        }
    }
}
