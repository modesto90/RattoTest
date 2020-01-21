using Ratto.Domain.Entities;
using Ratto.Domain.Interfaces.Repositories;
using Ratto.Infra.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ratto.Infra.Repositories
{
    public class RepositoryEndereco : RepositoryBase<Endereco>, IRepositoryEndereco
    {
        public RepositoryEndereco(RattoContext context)
            :base(context)
        {

        }
    }
}
