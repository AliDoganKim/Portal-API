using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Entities;

namespace Portal.Infrastructure.Persistence.Configurations.Polls
{
    public class PollConfiguration : IEntityTypeConfiguration<Poll>
    {
        public void Configure(EntityTypeBuilder<Poll> builder)
        {
            builder.Property(s => s.Name).HasMaxLength(255);
            builder.Property(s => s.StartDate).HasField("DateTime");
            builder.Property(s => s.EndDate).HasField("DateTime");
        }
    }
}