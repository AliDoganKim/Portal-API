using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
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
            builder.Property(s => s.Title).HasMaxLength(300);
            builder.Property(s => s.ShortDescription).HasMaxLength(450);
            builder.Property(s => s.Description).HasMaxLength(1500);
        }
    }
}