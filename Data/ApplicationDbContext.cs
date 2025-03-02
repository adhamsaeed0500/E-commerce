using E_commerce_System.Models;
using Microsoft.EntityFrameworkCore;

namespace E_commerce_System.Data
{
    public class ApplicationDbContext:DbContext
    {
       
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id= 1,  Name="Action" ,  DisplayOrder= 1 },
                new Category { Id = 2, Name = "History", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Wars", DisplayOrder = 3 });
        }
        public DbSet<Category> Categories { get; set; }



    }
}
