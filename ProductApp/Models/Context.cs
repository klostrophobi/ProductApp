using Microsoft.EntityFrameworkCore;

namespace ProductApp.Models
{
    public class Context : DbContext
    {
        public DbSet<Category> categories { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Sales> sales { get; set; }
    }
}
