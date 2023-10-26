namespace Core.Entities;

public class User : BaseEntity
{
    public string Login { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public ICollection<Like> Liked { get; set; }
    public ICollection<Comment> Comments { get; set; }
}