using Portal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities
{
    public class User : BaseEntity
    {
        public string FullName { get; set; }

        public string Email { get; set; }

        public bool IsDeleted { get; set; }

        public virtual ICollection<Article> Articles { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }

        public virtual ICollection<CourseAction> CourseActions { get; set; }

        public virtual ICollection<PollVotingRecord> PollVotingRecords { get; set; }
    }
}