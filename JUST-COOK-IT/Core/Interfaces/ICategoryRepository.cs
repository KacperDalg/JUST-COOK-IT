using Core.Entities;

namespace Core.Interfaces;

public interface ICategoryRepository
{
    Task<Category> GetCategoryByIdAsync(int categoryId);
    Task<IReadOnlyList<Category>> GetCategoriesAsync();
}