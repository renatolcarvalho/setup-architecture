using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using App.Business.Interfaces.Services;
using App.Business.Interfaces.Repositories;
using AutoMapper;

namespace App.Business.Services
{
    public class ServiceBase<TEntity, TEntityViewModel> : IServiceBase<TEntity, TEntityViewModel> where TEntity : class where TEntityViewModel : class
    {
        private readonly IRepositoryBase<TEntity> _repository;
        private readonly IUnitOfWork _uow;

        public ServiceBase(IRepositoryBase<TEntity> repository, IUnitOfWork uow)
        {
            _uow = uow;
            _repository = repository;
        }

        protected void Commit()
        {
            _uow.Commit();
        }

        public TEntityViewModel Add(TEntityViewModel entityViewModel)
        {
            var entity = Mapper.Map<TEntityViewModel, TEntity>(entityViewModel);
            entityViewModel = Mapper.Map<TEntity, TEntityViewModel>(_repository.Add(entity));
            Commit();

            return entityViewModel;
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
            Commit();
        }

        public TEntityViewModel FindById(Guid id)
        {
            return Mapper.Map<TEntity, TEntityViewModel>(_repository.FindById(id));
        }

        public IEnumerable<TEntityViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<TEntity>, IEnumerable<TEntityViewModel>>(_repository.GetAll());
        }

        public TEntityViewModel Update(TEntityViewModel entityViewModel)
        {
            var entity = Mapper.Map<TEntityViewModel, TEntity>(entityViewModel);
            entityViewModel = Mapper.Map<TEntity, TEntityViewModel>(_repository.Update(entity));
            Commit();

            return entityViewModel;
        }

        public void Dispose()
        {
            _repository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
