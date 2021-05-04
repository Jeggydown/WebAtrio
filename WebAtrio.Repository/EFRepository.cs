using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebAtrio.Repository.Interfaces;

namespace WebAtrio.Repository
{
    public class EFRepository<T> : IRepository<T> where T : class
    {
        #region Fields
        private DbSet<T> _entities;
        private IUnitOfWork _unitOfWork;
        #endregion Fields

        public EFRepository(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            this.Entities.ToList();
        }

        #region Properties
        public virtual IQueryable<T> Table
        {
            get { return this.Entities; }
        }

        protected DbSet<T> Entities
        {
            get { return _entities ?? (_entities = this._unitOfWork.Context.Set<T>()); }
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return this.Entities.Where(predicate).ToList();
        }

        public T First(Expression<Func<T, bool>> predicate)
        {
            return this.Entities.FirstOrDefault(predicate);
        }
        #endregion Properties
    }
}
