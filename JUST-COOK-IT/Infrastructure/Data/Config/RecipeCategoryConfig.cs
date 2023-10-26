using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config;

public class RecipeCategoryConfig : IEntityTypeConfiguration<RecipeCategory>
{
    public void Configure(EntityTypeBuilder<RecipeCategory> builder)
    {
        builder.HasKey(rc => new { rc.RecipeId, rc.CategoryId });

        builder.HasOne(rc => rc.Recipe)
            .WithMany(r => r.RecipeCategories)
            .HasForeignKey(rc => rc.RecipeId);

        builder.HasOne(rc => rc.Category)
            .WithMany(c => c.RecipeCategories)
            .HasForeignKey(rc => rc.CategoryId);
    }
}