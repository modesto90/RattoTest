using Microsoft.EntityFrameworkCore;
using Ratto.Domain.Interfaces.Repositories;
using Ratto.Infra.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ratto.Infra.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected readonly RattoContext _context;

        public RepositoryBase(RattoContext context)
        {
            _context = context;
        }

        public void Add(TEntity obj)
        {
            _context.Set<TEntity>().Add(obj);
            _context.SaveChanges();
        }

        public virtual TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>();
        }

        public void Update(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Remove(TEntity obj)
        {
            _context.Set<TEntity>().Remove(obj);
            _context.SaveChanges();
        }

        public void Dispose()
        {

        }
    }
}
