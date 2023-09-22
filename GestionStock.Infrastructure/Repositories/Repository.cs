using GestionStock.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T:class
    {
        protected readonly GestionStockContext _context;

        public Repository(GestionStockContext context)
        {
            _context = context;
        }
        public virtual T Add(T entity)
        {
           return _context
                .Add(entity)
                .Entity;
        }

        public virtual IEnumerable<T> All()
        {
            return _context
                .Set<T>()
                .AsQueryable()
                .ToList();
        }

        public virtual void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public virtual IEnumerable<T> Find(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>()
                .AsQueryable()
                .Where(predicate).ToList();
        }

        public virtual T Get(int id)
        {
            return _context.Find<T>(id);
        }

        public virtual void SaveChanges()
        {
            _context.SaveChanges();
        }

        public virtual T Update(T entity)
        {
            return _context.Update(entity).Entity;
        }
    }
}
