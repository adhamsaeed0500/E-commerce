using E_commerce_System.Layer.DataAccess.Repository.IRepository;
using Layer.DataAccess.Data;
using Layer.Models;

namespace E_commerce_System.Layer.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

       

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
