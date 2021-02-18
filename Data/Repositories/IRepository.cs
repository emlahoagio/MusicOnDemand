using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Data.Repositories
{
    public interface IRepository<T> where T : class
    {
        public IQueryable<T> GetAll();
        public IQueryable<T> GetMany(Expression<Func<T, bool>> predicate);
        public void Add(T entity);
        public void AddRange(IEnumerable<T> entities);
        public void Update(T entity);
        public void UpdateRange(IEnumerable<T> entities);
        public void Remove(T entity);
        public void RemoveRange(IEnumerable<T> entities);
    }
}
