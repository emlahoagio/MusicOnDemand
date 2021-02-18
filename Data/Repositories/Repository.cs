using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbSet<T> _entities;
        public Repository(MusicOnDemandContext db)
        {
            _entities = db.Set<T>();
        }

        public void Add(T entity)
        {
            _entities.Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _entities.AddRange(entities);
        }

        public IQueryable<T> GetAll()
        {
            return _entities;
        }

        public IQueryable<T> GetMany(Expression<Func<T, bool>> predicate)
        {
            return _entities.Where(predicate);
        }

        public void Remove(T entity)
        {
            _entities.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _entities.RemoveRange(entities);
        }

        public void Update(T entity)
        {
            _entities.Update(entity);
        }

        public void UpdateRange(IEnumerable<T> entities)
        {
            _entities.UpdateRange(entities);
        }
    }
}
