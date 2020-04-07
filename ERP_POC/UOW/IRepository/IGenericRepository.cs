using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;


namespace ERP_POC.UOW.IRepository
{
    public abstract  class IGenericRepository<T> where T : class
    {
        abstract protected void Add(T entity);
        abstract protected void AddRange(IEnumerable<T> entities);
        protected abstract void Update(int id, T entity);
        abstract protected void Remove(T entity);
        abstract protected void RemoveRange(IEnumerable<T> entities);
        abstract protected T Get(int id);
        abstract protected IEnumerable<T> GetAll();
        abstract protected IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
    }
}