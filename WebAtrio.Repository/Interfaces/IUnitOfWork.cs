using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace WebAtrio.Repository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        DbContext Context { get; }

        void Commit();
    }
}
