using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Entities;

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