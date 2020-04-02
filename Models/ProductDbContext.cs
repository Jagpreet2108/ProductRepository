using Hangfire.Annotations;
using Microsoft.EntityFrameworkCore;

namespace OurProduct.Models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData
                (
                new Product { PId = 1, PName = "Pen", PDesc = "Stationery", PPrice = 10 },
                    new Product { PId = 2, PName = "Mobile", PDesc = "Gadget", PPrice = 500 },
                          new Product { PId = 3, PName = "Watch", PDesc = "Gadget", PPrice = 500 },
                           new Product { PId = 4, PName = "NoteBook", PDesc = "Stationery", PPrice = 50 }
                ) ;
        }
    }
}
