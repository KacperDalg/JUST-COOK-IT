namespace Core.Entities;

public class Recipe : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Views { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UserId { get; set; }
    public virtual User User { get; set; }
    public ICollection<Like> Likes { get; set; }
    public ICollection<RecipeCategory> RecipeCategories { get; set; }
    public ICollection<Image> Images { get; set; }
    public ICollection<Comment> Comments { get; set; }
}