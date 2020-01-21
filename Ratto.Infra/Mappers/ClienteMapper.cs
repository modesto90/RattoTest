using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ratto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ratto.Infra.Mappers
{
    public class ClienteMapper : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");
            builder.HasKey(x => x.Id);
            builder.Property(x=> x.Nome).HasColumnType("varchar(30)").IsRequired();
            builder.Property(x=> x.Idade).HasColumnType("varchar(3)").IsRequired();
            builder.OwnsOne(x=> x.Cpf);

        }
    }
}
