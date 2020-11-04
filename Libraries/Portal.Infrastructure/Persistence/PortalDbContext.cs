using Microsoft.EntityFrameworkCore;
using Portal.Domain.Entities;

namespace Portal.Infrastructure.Persistence
{
    public class PortalDbContext : DbContext
    {
        public PortalDbContext(DbContextOptions<PortalDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArticleCategory>()
                        .HasKey(f => new { f.ArticleId, f.CategoryId });

            modelBuilder.Entity<ArticleCategory>()
                        .HasOne(b => b.Article)
                        .WithMany(b => b.ArticleCategories)
                        .HasForeignKey(f => f.ArticleId);

            modelBuilder.Entity<ArticleCategory>()
                        .HasOne(b => b.Category)
                        .WithMany(b => b.ArticleCategories)
                        .HasForeignKey(f => f.CategoryId);

            modelBuilder.Entity<ArticleMedia>()
                        .HasKey(f => new { f.ArticleId, f.MediaId });

            modelBuilder.Entity<ArticleMedia>()
                        .HasOne(b => b.Article)
                        .WithMany(b => b.ArticleMedias)
                        .HasForeignKey(f => f.ArticleId);

            modelBuilder.Entity<ArticleMedia>()
                        .HasOne(b => b.Media)
                        .WithMany(b => b.ArticleMedias)
                        .HasForeignKey(f => f.MediaId);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PortalDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}