using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using SetupWebApplication.Repositories.Context;
using SetupWebApplication.Repositories.Interfaces;

namespace SetupWebApplication.Repositories.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected SetupWebApplicationContext Db = new SetupWebApplicationContext();

        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }

        public void AddRange(List<TEntity> obj)
        {
            Db.Set<TEntity>().AddRange(obj);
            Db.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }

        public void RemoveRange(List<TEntity> obj)
        {
            Db.Set<TEntity>().RemoveRange(obj);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}