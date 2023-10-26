using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config;

public class ImageConfig : IEntityTypeConfiguration<Image>
{
    public void Configure(EntityTypeBuilder<Image> builder)
    {
        builder.HasKey(i => i.Id);

        builder.Property(i => i.ImagePath).IsRequired();

        builder.HasOne(i => i.Recipe)
            .WithMany(r => r.Images)
            .HasForeignKey(i => i.RecipeId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(i => i.Comment)
            .WithMany(c => c.Images)
            .HasForeignKey(i => i.CommentId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}