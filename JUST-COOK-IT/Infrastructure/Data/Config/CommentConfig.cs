using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config;

public class CommentConfig : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.HasKey(r => r.Id);

        builder.HasKey(c => c.Id);
        builder.Property(c => c.Text).IsRequired();

        builder.HasOne(c => c.User)
            .WithMany(u => u.Comments)
            .HasForeignKey(c => c.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(c => c.Recipe)
            .WithMany(r => r.Comments)
            .HasForeignKey(c => c.RecipeId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(c => c.Images)
            .WithOne(i => i.Comment)
            .HasForeignKey(i => i.CommentId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}