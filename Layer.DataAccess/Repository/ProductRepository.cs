using E_commerce_System.Layer.DataAccess.Repository.IRepository;
using E_commerce_System.Layer.Models;
using Layer.DataAccess.Data;

namespace E_commerce_System.Layer.DataAccess.Repository
{
    public class ProductRepository : Repository<Product> , IProducRepository
    {
        private ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context): base(context) 
        {
            _context = context;
        }
        public void Update(Product obj)
        {
            _context.Products.Update(obj);
        }
    }
}
