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

        public async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
        {
            var products = await _productRepository.GetAllProductsAsync();
            return products.Select(p => new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                ProductCode = p.ProductCode,
                Price = p.Price,
                Category = new CategoryDto
                {
                    Id = p.Category.Id,
                    Name = p.Category.Name
                }
            });
        }

        public async Task<ProductDto?> GetProductAsync(int id)
        {
            var product = await _productRepository.GetProductAsync(id);
            if (product == null)
                return null;
            return new ProductDto
                {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                ProductCode = product.ProductCode,
                Price = product.Price,
                Category = new CategoryDto
                {
                    Id = product.Category.Id,
                    Name = product.Category.Name
                }
            };
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

        public async Task DeleteAsync(int productId)
        {
            var product = await _productRepository.GetProductAsync(productId);

            if (product == null)
                throw new ArgumentException($"Product with ID {productId} does not exist.");

            await _productRepository.DeleteProductAsync(productId);
        }
    }
}
