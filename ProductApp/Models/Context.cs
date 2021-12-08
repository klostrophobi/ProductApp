using Microsoft.EntityFrameworkCore;

namespace ProductApp.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MVCApp;Integrated Security=True");
            //optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ProductApp;Integrated Security=True");
        }

        public DbSet<Category> TB_CATEGORIES { get; set; }
        public DbSet<Customer> TB_CUSTOMERS { get; set; }
        public DbSet<Product> TB_PRODUCTS { get; set; }
        public DbSet<Sales> TB_SALES { get; set; }
    }
}
