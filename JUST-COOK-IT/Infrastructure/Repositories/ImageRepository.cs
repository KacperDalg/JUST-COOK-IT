using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class ImageRepository : IImageRepository
{
    private readonly JustCookItDbContext _context;

    public ImageRepository(JustCookItDbContext context)
    {
        _context = context;
    }

    public async Task<IReadOnlyList<Image>> GetImagesForRecipe(int recipeId)
    {
        return await _context.Images
            .Where(i => i.RecipeId == recipeId)
            .ToListAsync();
    }

    public async Task<IReadOnlyList<Image>> GetImagesForComment(int commentId)
    {
        return await _context.Images
            .Where(i => i.CommentId == commentId)
            .ToListAsync();
    }
}