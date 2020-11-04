using Portal.Domain.Common;
using System.Collections.Generic;

namespace Portal.Domain.Entities
{
    public class Media : BaseEntity
    {
        public string Caption { get; set; }

        public int FileSize { get; set; }

        public string FileName { get; set; }

        public MediaType MediaType { get; set; }

        public virtual ICollection<ArticleMedia> ArticleMedias { get; set; }
    }
}