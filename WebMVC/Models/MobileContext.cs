using Microsoft.EntityFrameworkCore;

namespace WebMVC.Models
{
    public class MobileContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Image> Images { get; set; }

        public MobileContext(DbContextOptions<MobileContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}