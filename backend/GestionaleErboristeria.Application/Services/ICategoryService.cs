using GestionaleErboristeria.Application.DTOs;
using GestionaleErboristeria.Domain.Entities;

namespace GestionaleErboristeria.Application.Services
{
    public interface ICategoryService
    {
        Task CreateCategoryAsync(CreateCategoryDto dto);
        Task<IEnumerable<Category>> GetAllCategoriesAsync();
        Task<Category?> GetCategoryAsync(int id);
        Task UpdateCategoryAsync(int id, UpdateCategoryDto dto);
        Task DeleteCategoryAsync(int id);
    }
}
