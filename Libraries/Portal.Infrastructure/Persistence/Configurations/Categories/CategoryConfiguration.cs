using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Infrastructure.Persistence.Configurations.Categories
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(s => s.Name).HasMaxLength(300).IsRequired();
            builder.Property(s => s.Description).HasMaxLength(1000);
            builder.Property(s => s.MetaTitle).HasMaxLength(160);
            builder.Property(s => new { s.MetaDescription, s.MetaKeywords }).HasMaxLength(255);
            builder.HasIndex(s => s.Name).IsUnique();
        }
    }
}