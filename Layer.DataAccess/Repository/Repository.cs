using E_commerce_System.Layer.DataAccess.Repository.IRepository;
using Layer.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace E_commerce_System.Layer.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> _dbset;

        public Repository(ApplicationDbContext db)
        {
            _db = db;
            _dbset = _db.Set<T>();
        }
        public void Add(T entity)
        {
            _dbset.Add(entity);
        }

        public T Get(Expression<Func<T, bool>> filter, string? includeProperties = null)
        {
            IQueryable<T> query = _dbset;
            if (!string.IsNullOrEmpty(includeProperties)) 
            { 
                foreach (var property in includeProperties.Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries)) 
                {
                    query = query.Include(property);
                }                                   
            }
           return query.FirstOrDefault(filter);                                     
        }

        public IEnumerable<T> GetAll(string? includeProperties = null)
        {
            IQueryable<T> query = _dbset;
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var property in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(property);
                }
            }
            return query.ToList();
        }

        public void Remove(T entity)
        {
            _dbset.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            _dbset.RemoveRange(entity);
        }
    }
}
