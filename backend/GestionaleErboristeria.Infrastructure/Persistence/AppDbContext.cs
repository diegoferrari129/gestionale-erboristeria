using GestionaleErboristeria.Domain.Entities;
using GestionaleErboristeria.Infrastructure.Persistence.Seed;
using Microsoft.EntityFrameworkCore;

namespace GestionaleErboristeria.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Batch> Batches => Set<Batch>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Category> Categories => Set<Category>();

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
          //  base.OnModelCreating(modelBuilder);
            //DataSeeder.Seed(modelBuilder);
        //}
    }
}
