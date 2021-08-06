using Microsoft.EntityFrameworkCore;
using ProjetoCliente.Domain.Contracts.Repositories;
using ProjetoCliente.Infra.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto01.Infra.Data.SqlServer.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : class
    {
        private readonly SqlContext sqlContext;
        private Microsoft.SqlServer.Server.SqlContext sqlcontext;

        public BaseRepository(SqlContext sqlContext)
        {
            this.sqlContext = sqlContext;
        }

        public BaseRepository(Microsoft.SqlServer.Server.SqlContext sqlcontext)
        {
            this.sqlcontext = sqlcontext;
        }

        public virtual void Create(TEntity entity)
        {
            sqlContext.Entry(entity).State = EntityState.Added;
            sqlContext.SaveChanges();
        }

        public virtual void Update(TEntity entity)
        {
            sqlContext.Entry(entity).State = EntityState.Modified;
            sqlContext.SaveChanges();
        }

        public virtual void Delete(TEntity entity)
        {
            sqlContext.Entry(entity).State = EntityState.Deleted;
            sqlContext.SaveChanges();
        }

        public virtual List<TEntity> GetAll()
        {
            return sqlContext
                .Set<TEntity>()
                .ToList();
        }

        public virtual List<TEntity> GetAll(Func<TEntity, bool> where)
        {
            return sqlContext
                .Set<TEntity>()
                .Where(where)
                .ToList();
        }

        public virtual TEntity GetById(Guid id)
        {
            return sqlContext
                .Set<TEntity>()
                .Find(id);
        }

        public virtual TEntity Get(Func<TEntity, bool> where)
        {
            return sqlContext
                .Set<TEntity>()
                .FirstOrDefault(where);
        }

        public int Count()
        {
            return sqlContext
                .Set<TEntity>()
                .Count();
        }

        public int Count(Func<TEntity, bool> where)
        {
            return sqlContext
                .Set<TEntity>()
                .Count(where);
        }

        public void Dispose()
        {
            sqlContext.Dispose();
        }
    }
}
