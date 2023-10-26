using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly JustCookItDbContext _context;

    public CategoryRepository(JustCookItDbContext context)
    {
        _context = context;
    }

    public async Task<Category?> GetCategoryByIdAsync(int userId)
    {
        return await _context.Categories.FirstOrDefaultAsync(u => u.Id == userId);
    }

    public async Task<IReadOnlyList<Category>> GetCategoriesAsync()
    {
        return await _context.Categories.ToListAsync();
    }
}