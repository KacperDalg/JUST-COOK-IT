using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class JustCookItDbContext : DbContext
{
    public JustCookItDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<CategoryType> CategoryTypes { get; set; }
    public DbSet<Like> Likes { get; set; }
    public DbSet<RecipeCategory> RecipeCategories { get; set; }
    public DbSet<Image> Images { get; set; }
    public DbSet<Comment> Comments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}