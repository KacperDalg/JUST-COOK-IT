namespace Core.Entities;

public class Image : BaseEntity
{
    public string ImagePath { get; set; }

    public int RecipeId { get; set; }
    public virtual Recipe Recipe { get; set; }
    public int CommentId { get; set; }
    public virtual Comment Comment { get; set; }
}