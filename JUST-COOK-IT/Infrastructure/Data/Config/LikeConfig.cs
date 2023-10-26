using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config;

public class LikeConfig : IEntityTypeConfiguration<Like>
{
    public void Configure(EntityTypeBuilder<Like> builder)
    {
        builder.HasKey(l => new { l.UserId, l.RecipeId });

        builder.HasOne(l => l.User)
            .WithMany(u => u.Liked)
            .HasForeignKey(l => l.UserId);

        builder.HasOne(l => l.Recipe)
            .WithMany(r => r.Likes)
            .HasForeignKey(l => l.RecipeId);
    }
}