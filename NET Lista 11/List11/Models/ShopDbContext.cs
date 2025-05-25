using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Globalization;
using System.Linq;

namespace List10.Models
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Article> Article { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Console.WriteLine("on model creating executing");
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }

        public void UpdateArticle(DbContext context, Article article)
        {
            var existingArticle = context.Set<Article>().FirstOrDefault(a => a.Id == article.Id);

            if (existingArticle != null)
            {
                existingArticle.Name = article.Name;
                existingArticle.CategoryId = article.CategoryId;
                existingArticle.Price = article.Price;


                context.SaveChanges();
            }
        }
    }
}
