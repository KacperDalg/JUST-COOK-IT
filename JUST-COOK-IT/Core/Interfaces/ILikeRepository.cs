using Core.Entities;

namespace Core.Interfaces;

public interface ILikeRepository
{
    Task<int> CountLikesForRecipe(int recipeId);
}