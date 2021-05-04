using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace WebAtrio.Repository.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        TEntity First(Expression<Func<TEntity, bool>> predicate);
    }
}
