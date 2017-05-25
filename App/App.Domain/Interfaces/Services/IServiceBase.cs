using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace App.Business.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        TEntity Add(TEntity entity);
        void Delete(Guid id);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        TEntity FindById(Guid id);
        IEnumerable<TEntity> GetAll();
        int SaveChanges();
        TEntity Update(TEntity entity);
    }
}
