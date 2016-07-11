
using System.Collections.Generic;

namespace SetupWebApplication.Repositories.Interfaces
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        void AddRange(List<TEntity> obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void RemoveRange(List<TEntity> obj);
        void Dispose();
    }
}