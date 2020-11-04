namespace Portal.Domain.Entities
{
    public class ArticleMedia
    {
        public int ArticleId { get; set; }

        public Article Article { get; set; }

        public int MediaId { get; set; }

        public Media Media { get; set; }
    }
}