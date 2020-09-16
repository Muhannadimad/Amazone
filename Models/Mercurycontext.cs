using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace Mercury.Models
{

    public class MercuryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseMySql("server=localhost; database=Mercury; user=root; pwd=123123;");
            }
        }

      
      

    }
}

