using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace App.Business.Interfaces.Services
{
    public interface IServiceBase<TEntity, TEntityViewModel> : IDisposable where TEntity : class where TEntityViewModel : class
    {
        TEntityViewModel Add(TEntityViewModel entityViewModel);
        void Delete(Guid id);
        TEntityViewModel FindById(Guid id);
        IEnumerable<TEntityViewModel> GetAll();
        TEntityViewModel Update(TEntityViewModel entity);
    }
}
