namespace Core.Entities;

public class Like
{
    public int UserId { get; set; }
    public virtual User User { get; set; }

    public int RecipeId { get; set; }
    public virtual Recipe Recipe { get; set; }
}