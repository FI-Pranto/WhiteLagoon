using Microsoft.EntityFrameworkCore;
using WhiteLagoon.Web.Models;

namespace WhiteLagoon.Web.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        public DbSet<Villa> Villas { get; set; }


       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Villa>().HasData(
                new Villa { Id = 1, Name = "LKD", Description = "Ok and Nice", Price = 10000, Sqft = 10, Occupancy = 20, CreatedAt=DateTime.Today},
                new Villa { Id = 2, Name = "Hila", Description = "Ok and Nice", Price = 12000, Sqft = 20, Occupancy = 10, CreatedAt=DateTime.Today}
                );

        }



    }
}
