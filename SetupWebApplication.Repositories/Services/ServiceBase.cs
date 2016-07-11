using System;
using System.Collections.Generic;
using SetupWebApplication.Repositories.Interfaces;

namespace SetupWebApplication.Repositories.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;
        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public void Add(TEntity obj)
        {
            _repository.Add(obj);
        }

        public void AddRange(List<TEntity> obj)
        {
            _repository.AddRange(obj);
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }

        public void RemoveRange(List<TEntity> obj)
        {
            _repository.RemoveRange(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
