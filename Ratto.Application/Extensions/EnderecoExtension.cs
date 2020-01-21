using Ratto.Application.Dtos;
using Ratto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ratto.Application.Extensions
{
    public static class EnderecoExtension
    {
        public static IEnumerable<EnderecoDTO> ConverterEntidadesEmDtos(this IEnumerable<Endereco> entities)
        {
            return entities.Select(ConverterEntidadeEmDto);
        }

        public static EnderecoDTO ConverterEntidadeEmDto(this Endereco entity)
        {
            return new EnderecoDTO(entity.Id, 
                entity.Logradouro.Valor,
                entity.Bairro.Valor,
                entity.Cidade.Valor,
                entity.Estado.Valor) ;
        }
    }
}
