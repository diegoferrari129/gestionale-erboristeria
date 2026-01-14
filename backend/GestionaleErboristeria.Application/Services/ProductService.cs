using GestionaleErboristeria.Application.DTOs;
using GestionaleErboristeria.Application.Interfaces;
using GestionaleErboristeria.Domain.Entities;

namespace GestionaleErboristeria.Application.Services
{
    /// <summary>
    /// Provides operations for creating and managing products within the application.
    /// </summary>
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task CreateProductAsync(CreateProductDto dto)
        {
            var product = new Product
            {
                Name = dto.Name,
                Description = dto.Description,
                ProductCode = dto.ProductCode,
                Price = dto.Price,
                CategoryId = dto.CategoryId
            };

            await _productRepository.AddProductAsync(product);
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllProductsAsync();
        }

        public async Task<Product?> GetProductAsync(int id)
        {
            return await _productRepository.GetProductAsync(id);
        }

        public async Task UpdateAsync(int id, UpdateProductDto dto)
        {
            var product = await _productRepository.GetProductAsync(id);

            if (product == null)
                throw new ArgumentException($"Product with ID {id} does not exist.");

            product.Name = dto.Name;
            product.Description = dto.Description;
            product.ProductCode = dto.ProductCode;
            product.Price = dto.Price;
            product.CategoryId = dto.CategoryId;

            await _productRepository.UpdateProductAsync(product);
        }

        public async Task DeleteAsync(int id)
        {
            var product = await _productRepository.GetProductAsync(id);

            if (product == null)
                throw new ArgumentException($"Product with ID {id} does not exist.");

            await _productRepository.DeleteProductAsync(product);
        }
    }
}
