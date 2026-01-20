using GestionaleErboristeria.Application.Interfaces;
using GestionaleErboristeria.Domain.Entities;
using GestionaleErboristeria.Infrastructure.Persistence;
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
        private readonly AppDbContext _contex;

        public ProductRepository(AppDbContext contex)
        {
            _contex = contex;
        }

        public async Task<Product?> GetProductAsync(int productId)
        {
            return await _contex.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(p => p.Id == productId);
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _contex.Products
                .Include(p => p.Category)
                .ToListAsync();
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
        public async Task DeleteProductAsync(Product product)
        {
            _contex.Products.Remove(product);
            await _contex.SaveChangesAsync();
        }
    }
}
