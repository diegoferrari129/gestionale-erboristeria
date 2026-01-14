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
    }
}
