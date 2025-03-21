using E_commerce_System.Layer.DataAccess.Repository.IRepository;
using Layer.DataAccess.Data;

namespace E_commerce_System.Layer.DataAccess.Repository
{
    public class ProductRepository : Repository<ProductRepository>, IProducRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context): base(context) 
        {
            _context = context;
        }
        public void Update(ProductRepository obj)
        {
            throw new NotImplementedException();
        }
    }
}
