using GestionaleErboristeria.Application.DTOs;
using GestionaleErboristeria.Application.Interfaces;
using GestionaleErboristeria.Domain.Entities;

namespace GestionaleErboristeria.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task CreateCategoryAsync(CreateCategoryDto dto)
        {
            var category = new Category
            {
                Name = dto.Name,
                Description = dto.Description
            };
            await _categoryRepository.AddCategoryAsync(category);
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await _categoryRepository.GetAllCategoriesAsync();
        }

        public async Task<Category?> GetCategoryAsync(int id)
        {
            return await _categoryRepository.GetCategoryByIdAsync(id);
        }

        public async Task UpdateCategoryAsync(int id, UpdateCategoryDto dto)
        {
            var category = await _categoryRepository.GetCategoryByIdAsync(id);
            if (category == null)
            {
                throw new Exception("Category not found");
            }
            category.Name = dto.Name;
            category.Description = dto.Description;
            await _categoryRepository.UpdateCategoryAsync(category);
        }

        public async Task DeleteCategoryAsync(int id)
        {
            var category = await _categoryRepository.GetCategoryByIdAsync(id);
            if (category == null)
            {
                throw new Exception("Category not found");
            }
            await _categoryRepository.DeleteCategoryAsync(category);
        }
    }
}
