using E_commerce_System.Layer.Models;

namespace E_commerce_System.Layer.DataAccess.Repository.IRepository
{
    public interface IProducRepository:IRepository<ProductRepository>
    {
        public void Update(ProductRepository obj);
    }
}
