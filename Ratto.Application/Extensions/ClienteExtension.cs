using Ratto.Application.Dtos;
using Ratto.Application.DTOS;
using Ratto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ratto.Application.Extensions
{
    public static class ClienteExtension
    {
        public static IEnumerable<ClienteDTO> ConverterEntidadesEmDtos(this IEnumerable<Cliente> entities)
        {
            return entities.Select(ConverterEntidadeEmDto);
        }

        public static ClienteDTO ConverterEntidadeEmDto(this Cliente entity)
        {
            return new ClienteDTO(entity.Id,entity.Nome, entity.Cpf.Numero, entity.Idade);
        }
    }
}
