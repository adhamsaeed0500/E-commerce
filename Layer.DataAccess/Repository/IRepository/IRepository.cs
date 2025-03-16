using System.Linq.Expressions;

namespace E_commerce_System.Layer.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {

        IEnumerable<T> GetAll();
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
    }
}
