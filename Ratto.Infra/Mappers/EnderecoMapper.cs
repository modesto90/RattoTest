using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ratto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ratto.Infra.Mappers
{
    public class EnderecoMapper : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");
            builder.HasKey(x => x.Id);
            builder.OwnsOne(x => x.Bairro);
            builder.OwnsOne(x => x.Cidade);
            builder.OwnsOne(x => x.Estado);
            builder.OwnsOne(x => x.Logradouro);

        }
    
    }
}
