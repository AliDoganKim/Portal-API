using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Common;
using Portal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Infrastructure.Persistence.Configurations.Polls
{
    public class PollAnswerConfiguration : IEntityTypeConfiguration<PollAnswer>
    {
        public void Configure(EntityTypeBuilder<PollAnswer> builder)
        {
            builder.Property(s => s.Name).IsRequired().HasMaxLength((int)MaxLengthSize.Name);
            builder.Property(s => s.PollId).IsRequired();
        }
    }
}