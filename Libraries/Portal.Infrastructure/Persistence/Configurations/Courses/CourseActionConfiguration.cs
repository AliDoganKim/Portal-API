using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Common;
using Portal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Infrastructure.Persistence.Configurations.Courses
{
    public class CourseActionConfiguration : IEntityTypeConfiguration<CourseAction>
    {
        public void Configure(EntityTypeBuilder<CourseAction> builder)
        {
            builder.Property(s => new { s.UserId, s.CourseId, s.CourseLessonId }).IsRequired();
        }
    }
}