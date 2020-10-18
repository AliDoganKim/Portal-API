using Portal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities
{
    public class Article : BaseEntity
    {
        public string Title { get; set; }

        public string ShortDescription { get; set; }

        public string Description { get; set; }

        public int? ThumbnailImageId { get; set; }

        public virtual Media ThumbnailImage { get; set; }

        public int ReviewsCount { get; set; }

        public double RatingAverage { get; set; }

        public bool IsPublished { get; set; }

        public virtual ICollection<ArticleMedia> ArticleMedias { get; set; }

        public virtual ICollection<ArticleCategory> ArticleCategories { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}