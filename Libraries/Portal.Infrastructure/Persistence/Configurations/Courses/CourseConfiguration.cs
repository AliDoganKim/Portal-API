using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Infrastructure.Persistence.Configurations.Courses
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(200);
            builder.Property(s => s.Description).HasMaxLength(1000);
            builder.Property(s => s.ShortDescription).HasMaxLength(500);
            builder.Property(s => s.MetaTitle).HasMaxLength(160);
            builder.Property(s => new { s.MetaDescription, s.MetaKeywords }).HasMaxLength(255);
        }
    }
}