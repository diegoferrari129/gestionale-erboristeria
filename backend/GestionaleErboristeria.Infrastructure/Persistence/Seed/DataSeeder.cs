using GestionaleErboristeria.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GestionaleErboristeria.Infrastructure.Persistence.Seed
{
    public static class DataSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Tisane"
                },
                new Category
                {
                    Id = 2,
                    Name = "Integratori"
                }
            );
            
        }
    }
}
