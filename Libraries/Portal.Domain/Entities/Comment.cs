using Portal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities
{
    public class Comment : BaseEntity
    {
        public int? UserId { get; set; }

        public virtual User User { get; set; }

        public int ArticleId { get; set; }

        public virtual Article Article { get; set; }

        public CommentStatus Status { get; set; } = CommentStatus.Pending;

        public string CommentText { get; set; }

        public string CommenterName { get; set; }

        public string CommenterEmail { get; set; }

        public int? ParentId { get; set; }

        public Comment Parent { get; set; }

        public IList<Comment> Replies { get; protected set; } = new List<Comment>();
    }
}