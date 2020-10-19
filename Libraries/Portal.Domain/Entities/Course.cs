using Portal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities
{
    public class Course : BaseEntity
    {
        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string Description { get; set; }

        public bool IsPublished { get; set; }

        public string MetaKeywords { get; set; }

        public string MetaDescription { get; set; }

        public string MetaTitle { get; set; }

        public virtual ICollection<CourseLesson> CourseLessons { get; set; }

        public virtual ICollection<CourseAction> CourseActions { get; set; }
    }
}