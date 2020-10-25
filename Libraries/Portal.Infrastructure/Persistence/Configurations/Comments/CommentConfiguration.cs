using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Common;
using Portal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Infrastructure.Persistence.Configurations.Comments
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.Property(s => s.ArticleId).IsRequired();
            builder.Property(s => s.CommentText).IsRequired().HasMaxLength((int)MaxLengthSize.Description);
            builder.Property(s => new { s.CommenterName, s.CommenterEmail }).IsRequired().HasMaxLength((int)MaxLengthSize.EmailAddress);
        }
    }
}