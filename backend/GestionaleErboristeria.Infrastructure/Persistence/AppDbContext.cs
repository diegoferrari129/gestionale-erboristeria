using GestionaleErboristeria.Domain.Entities;
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
    }
}
