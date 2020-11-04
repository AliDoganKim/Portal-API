using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Common;
using Portal.Domain.Entities;

namespace Portal.Infrastructure.Persistence.Configurations.Contacts
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.Property(s => s.FullName).IsRequired().HasMaxLength((int)MaxLengthSize.Name);
            builder.Property(s => s.EmailAddress).IsRequired().HasMaxLength((int)MaxLengthSize.EmailAddress);
            builder.Property(s => s.PhoneNumber).IsRequired().HasMaxLength((int)MaxLengthSize.PhoneNumber);
            builder.Property(s => s.Content).IsRequired().HasMaxLength((int)MaxLengthSize.Description);
        }
    }
}