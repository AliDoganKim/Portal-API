using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Infrastructure.Persistence.Configurations.Contacts
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.Property(s => s.FullName)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(s => s.EmailAddress).HasMaxLength(200);
            builder.Property(s => s.Content).HasMaxLength(800);
            builder.Property(s => s.PhoneNumber).HasMaxLength(50);
        }
    }
}