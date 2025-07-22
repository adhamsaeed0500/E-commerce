
using E_commerce_System.Layer.DataAccess.Repository.IRepository;
using Layer.DataAccess.Data;

namespace E_commerce_System.Layer.DataAccess.Repository
{
    public class UnitOfWork:IUnitOfWork
    {
        private ApplicationDbContext _db;
        public IShoppingCartRepository ShoppingCart { get; private set; }
        public ICategoryRepository Category { get; private set; }
        public IProducRepository Product { get; private set; }


        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            ShoppingCart = new ShoppingCartRepository(_db);
            Category = new CategoryRepository(_db);
            Product = new ProductRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
