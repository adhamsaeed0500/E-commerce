using E_commerce_System.Layer.Models;

namespace E_commerce_System.Layer.DataAccess.Repository.IRepository
{
    public interface IShoppingCartRepository : IRepository<ShoppingCart>
    {
        void Update(ShoppingCart obj);
    }
}