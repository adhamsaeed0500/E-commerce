using E_commerce_System.Data;
using E_commerce_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce_System.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }



    }
}
