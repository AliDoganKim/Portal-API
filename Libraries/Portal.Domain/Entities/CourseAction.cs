using Portal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities
{
    public class CourseAction : BaseEntity
    {
        public int UserId { get; set; }

        public virtual User User { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }

        public int CourseLessonId { get; set; }

        public virtual CourseLesson CourseLesson { get; set; }

        public bool Finished { get; set; }
    }
}