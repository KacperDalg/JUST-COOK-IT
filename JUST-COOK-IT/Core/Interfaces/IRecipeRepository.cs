using Core.Entities;

namespace Core.Interfaces;

public interface IRecipeRepository
{
    Task<Recipe> GetRecipeByIdAsync(int recipeId);
    Task<IReadOnlyList<Recipe>> GetRecipesAsync();
}