using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Common;
using Portal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Infrastructure.Persistence.Configurations.Articles
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.Property(s => s.Title).IsRequired().HasMaxLength((int)MaxLengthSize.Title);
            builder.Property(s => s.ShortDescription).IsRequired().HasMaxLength((int)MaxLengthSize.ShortDescription);
            builder.Property(s => s.Description).IsRequired().HasMaxLength((int)MaxLengthSize.Description);
        }
    }
}