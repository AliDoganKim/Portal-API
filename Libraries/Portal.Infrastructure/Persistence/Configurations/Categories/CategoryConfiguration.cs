using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Common;
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
            builder.Property(s => s.Name).IsRequired().HasMaxLength((int)MaxLengthSize.Name);
            builder.Property(s => s.Description).IsRequired().HasMaxLength((int)MaxLengthSize.Description);
            builder.Property(s => s.MetaTitle).IsRequired().HasMaxLength((int)MaxLengthSize.MetaTitle);
            builder.Property(s => s.MetaKeywords).IsRequired().HasMaxLength((int)MaxLengthSize.MetaDescription);
            builder.Property(s => s.MetaDescription).IsRequired().HasMaxLength((int)MaxLengthSize.MetaDescription);
            builder.HasIndex(s => s.Name).IsUnique();
        }
    }
}