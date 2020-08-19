using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Mercury{
    public class Mercurycontext : DbContext{
        public DbSet<product> products {get; set;}
         
       
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL("server=localhost; database=Mercury; user=; password=;" );
    }
    
    }
}
