using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using App.Business.Interfaces.Services;
using App.Business.Interfaces.Repositories;

namespace App.Business.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;
        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public TEntity Add(TEntity entity)
        {
            return _repository.Add(entity);
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _repository.Find(predicate);
        }

        public TEntity FindById(Guid id)
        {
            return _repository.FindById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public int SaveChanges()
        {
            return _repository.SaveChanges();
        }

        public TEntity Update(TEntity entity)
        {
            return _repository.Update(entity);
        }
    }
}
