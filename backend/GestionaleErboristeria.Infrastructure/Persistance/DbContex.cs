using GestionaleErboristeria.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GestionaleErboristeria.Infrastructure.Persistance
{
    public class DbContex : DbContext
    {
        public DbContex(DbContextOptions<DbContex> options) : base(options)
        {
        }

        public DbSet<Batch> Batches => Set<Batch>();
        public DbSet<Product> Products => Set<Product>();
    }
}
