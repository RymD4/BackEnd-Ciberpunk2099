using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd_Ciberpunk2099.Models;

public class CategoryService
{
    private readonly CategoryRepository _categoryRepository;

    public CategoryService(CategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
    {
        return await _categoryRepository.GetAllCategoriesAsync();
    }

    public async Task<Category> GetCategoryByIdAsync(int categoryId)
    {
        return await _categoryRepository.GetCategoryByIdAsync(categoryId);
    }

    public async Task AddCategoryAsync(Category category)
    {
        await _categoryRepository.AddCategoryAsync(category);
    }

    public async Task UpdateCategoryAsync(Category category)
    {
        await _categoryRepository.UpdateCategoryAsync(category);
    }

    public async Task DeleteCategoryAsync(int categoryId)
    {
        await _categoryRepository.DeleteCategoryAsync(categoryId);
    }
}
