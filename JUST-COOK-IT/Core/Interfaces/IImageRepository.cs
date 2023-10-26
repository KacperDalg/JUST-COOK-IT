using Core.Entities;

namespace Core.Interfaces;

public interface IImageRepository
{
    Task<IReadOnlyList<Image>> GetImagesForRecipe(int recipeId);
    Task<IReadOnlyList<Image>> GetImagesForComment(int commentId);
}