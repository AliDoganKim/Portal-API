using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Common;
using Portal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Infrastructure.Persistence.Configurations.Polls
{
    public class PollVotingRecordConfiguration : IEntityTypeConfiguration<PollVotingRecord>
    {
        public void Configure(EntityTypeBuilder<PollVotingRecord> builder)
        {
            builder.Property(s => new { s.PollId, s.PollAnswerId }).IsRequired();
        }
    }
}