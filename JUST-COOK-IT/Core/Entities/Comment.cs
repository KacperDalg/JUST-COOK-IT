namespace Core.Entities;

public class Comment : BaseEntity
{
    public string Text { get; set; }
    public int UserId { get; set; }
    public virtual User User { get; set; }
    public int RecipeId { get; set; }
    public virtual Recipe Recipe { get; set; }
    public ICollection<Image> Images { get; set; }
}