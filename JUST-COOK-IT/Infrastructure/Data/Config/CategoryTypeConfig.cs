using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config;

public class CategoryTypeConfig : IEntityTypeConfiguration<CategoryType>
{
    public void Configure(EntityTypeBuilder<CategoryType> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(50);
    }
}