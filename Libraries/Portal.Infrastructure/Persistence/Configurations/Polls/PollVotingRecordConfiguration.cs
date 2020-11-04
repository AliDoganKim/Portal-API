using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Entities;

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