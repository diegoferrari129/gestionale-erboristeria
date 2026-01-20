using GestionaleErboristeria.Application.DTOs;
using GestionaleErboristeria.Domain.Entities;

namespace GestionaleErboristeria.Application.Services
{
    public interface IProductService
    {
        Task CreateProductAsync(CreateProductDto dto);
        Task<IEnumerable<ProductDto>> GetAllProductsAsync();
        Task<ProductDto?> GetProductAsync(int id);
        Task UpdateAsync(int id, UpdateProductDto dto);
        Task DeleteAsync(int productId);
    }
}
