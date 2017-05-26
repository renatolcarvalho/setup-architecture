using System;
using App.Business.Interfaces.Repositories;
using App.Data.Context;

namespace App.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MainContext _context;
        private bool _disposed;

        public UnitOfWork(MainContext context)
        {
            _context = context;
            _disposed = false;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
