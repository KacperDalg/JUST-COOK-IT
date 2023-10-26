using Core.Entities;

namespace Core.Interfaces;

public interface ICategoryTypeRepository
{
    Task<CategoryType> GetCategoryTypeByIdAsync(int categoryTypeId);
    Task<IReadOnlyList<CategoryType>> GetCategoryTypesAsync();
}