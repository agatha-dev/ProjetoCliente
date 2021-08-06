using System;
using System.Collections.Generic;

namespace ProjetoCliente.Domain.Contracts.Services
{
    public interface IClienteDomainService<TEntity> : IDisposable 
        where TEntity : class
    {
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        List<TEntity> Getall();
        TEntity GetById(Guid id);

    }
}
