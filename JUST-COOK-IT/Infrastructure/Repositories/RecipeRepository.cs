using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class RecipeRepository : IRecipeRepository
{
    private readonly JustCookItDbContext _context;

    public RecipeRepository(JustCookItDbContext context)
    {
        _context = context;
    }

    public async Task<Recipe?> GetRecipeByIdAsync(int recipeId)
    {
        return await _context.Recipes.FirstOrDefaultAsync(r => r.Id == recipeId);
    }

    public async Task<IReadOnlyList<Recipe>> GetRecipesAsync()
    {
        return await _context.Recipes.ToListAsync();
    }
}