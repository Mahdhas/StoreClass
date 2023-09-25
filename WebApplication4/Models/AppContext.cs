using Microsoft.EntityFrameworkCore;

 namespace WebApplication4.Models
{
    public class AppDBContext : DbContext
    {

        public AppDBContext(DbContextOptions<AppDBContext> op) : base(op)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
        }

        public DbSet<Product> TblProduct { get; set; }
        public DbSet<Category> TblCategory { get; set; }
    }

    //public class AppDbContext : DbContext
    //{
    //    public AppDbContext(DbContextOptions<AppDbContext> options)
    //    : base(options) { }
    //    public DbSet<Product> tblproduct { get; set; }
    //}
}

