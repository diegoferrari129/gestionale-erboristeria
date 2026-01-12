using GestionaleErboristeria.Application.Interfaces;
using GestionaleErboristeria.Domain.Entities;
using GestionaleErboristeria.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;

namespace GestionaleErboristeria.Infrastructure.Repositories
{
    /// <summary>
    /// Provides methods for accessing and managing products in the data store.
    /// </summary>
    /// <remarks>This repository implements the IProductRepository interface to support common operations such
    /// as retrieving, adding, and updating products. All methods are asynchronous and interact with the underlying
    /// database context.</remarks>
    public class ProductRepository : IProductRepository
    {
        private readonly DbContex _contex;

        public ProductRepository(DbContex contex)
        {
            _contex = contex;
        }

        public async Task<Product?> GetProductAsync(int productId)
        {
            return await _contex.Products
                .FirstOrDefaultAsync(p => p.Id == productId);
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _contex.Products.ToListAsync();
        }

        public async Task AddProductAsync(Product product)
        {
            await _contex.Products.AddAsync(product);
            await _contex.SaveChangesAsync();
        }

        public async Task UpdateProductAsync(Product product)
        {
            _contex.Products.Update(product);
            await _contex.SaveChangesAsync();
        }
    }
}
