using GestionaleErboristeria.Application.DTOs;
using GestionaleErboristeria.Domain.Entities;

namespace GestionaleErboristeria.Application.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllCategoriesAsync();
        Task<Category?> GetCategoryAsync(int id);
        Task CreateCategoryAsync(CreateCategoryDto dto);
    }
}
