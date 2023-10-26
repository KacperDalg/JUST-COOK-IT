using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class LikeRepository : ILikeRepository
{
    private readonly JustCookItDbContext _context;

    public LikeRepository(JustCookItDbContext context)
    {
        _context = context;
    }

    public async Task<int> CountLikesForRecipe(int recipeId)
    {
        return await _context.Likes.CountAsync(l => l.RecipeId == recipeId);
    }
}