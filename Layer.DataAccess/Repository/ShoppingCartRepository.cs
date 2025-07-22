using BulkyBook.Models;
using E_commerce_System.Layer.DataAccess.Repository.IRepository;
using Layer.DataAccess.Data;

namespace E_commerce_System.Layer.DataAccess.Repository
{
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        private ApplicationDbContext _db;
        public ShoppingCartRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }



        public void Update(ShoppingCart obj)
        {
            _db.ShoppingCarts.Update(obj);
        }
    }
}
