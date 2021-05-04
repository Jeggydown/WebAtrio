using System;
using System.Data.Entity;
using WebAtrio.Dao;
using WebAtrio.Repository.Interfaces;

namespace WebAtrio.Repository
{
    public class EFUnitOfWork : IUnitOfWork, IDisposable
    {
        private bool disposed;

        public EFUnitOfWork()
        {
            disposed = false;
            this.Context = new WebAtrioDbContext();
        }

        public DbContext Context { get; private set; }

        public void Commit()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                    Context.Dispose();

                this.disposed = true;
            }
        }
    }
}
