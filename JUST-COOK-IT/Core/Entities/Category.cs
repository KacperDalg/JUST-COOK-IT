namespace Core.Entities;

public class Category : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int CategoryTypeId { get; set; }
    public virtual CategoryType CategoryType { get; set; }
    public ICollection<RecipeCategory> RecipeCategories { get; set; }
}