using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class CategoryTypeRepository : ICategoryTypeRepository
{
    private readonly JustCookItDbContext _context;

    public CategoryTypeRepository(JustCookItDbContext context)
    {
        _context = context;
    }

    public async Task<CategoryType?> GetCategoryTypeByIdAsync(int categoryTypeId)
    {
        return await _context.CategoryTypes.FirstOrDefaultAsync(c => c.Id == categoryTypeId);
    }

    public async Task<IReadOnlyList<CategoryType>> GetCategoryTypesAsync()
    {
        return await _context.CategoryTypes.ToListAsync();
    }
}