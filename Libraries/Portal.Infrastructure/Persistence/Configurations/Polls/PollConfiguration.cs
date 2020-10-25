using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Common;
using Portal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Infrastructure.Persistence.Configurations.Polls
{
    public class PollConfiguration : IEntityTypeConfiguration<Poll>
    {
        public void Configure(EntityTypeBuilder<Poll> builder)
        {
            builder.Property(s => s.Name).IsRequired().HasMaxLength((int)MaxLengthSize.Name);
        }
    }
}