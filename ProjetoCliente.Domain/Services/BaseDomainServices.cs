using ProjetoCliente.Domain.Contracts.Repositories;
using ProjetoCliente.Domain.Contracts.Services;
using System;
using System.Collections.Generic;

namespace ProjetoCliente.Domain.Services
{
    public abstract class BaseDomainServices<TEntity>
       : IBaseDomainService<TEntity>
       where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _baseRepository;

        protected BaseDomainServices(IBaseRepository<TEntity> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public void Create(TEntity entity)
        {
            _baseRepository.Create(entity);
        }


        public void delete(TEntity entity)
        {
            _baseRepository.Delete(entity);
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _baseRepository.Dispose();
        }

        public List<TEntity> Getall()
        {
            return _baseRepository.GetAll();
        }

        public TEntity GetById(Guid Id)
        {
            return _baseRepository.GetById(Id);
        }

        public void update(TEntity entity)
        {
            _baseRepository.Update(entity);
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}