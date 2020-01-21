using Microsoft.EntityFrameworkCore;
using Ratto.Domain.Entities;
using Ratto.Infra.Mappers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ratto.Infra.Context
{
   public class RattoContext : DbContext
    {
        public RattoContext(DbContextOptions<RattoContext> options)
            : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Endereços { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMapper());
            modelBuilder.ApplyConfiguration(new EnderecoMapper());
        }


            
  }
}
