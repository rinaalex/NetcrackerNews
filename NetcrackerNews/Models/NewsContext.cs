using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NetcrackerNews.Models
{
    public class NewsContext: DbContext
    {
        public DbSet<Article> Articles { get; set; }

        public NewsContext(DbContextOptions<NewsContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>().HasData(new Article
            {
                ArticleId = 1,
                Title = "Welcome",
                Text = @"Каждая новость состоит из заголовка длиной 100 символов и текста (длина не ограничена), оба поля обязательные. 
                        На ленте новостей должен отображаться не полный текст новости, а только первые 200 символов с кнопкой 'читать полностью',
                        которая разворачивает текст целиком.",
                TimeStamp = DateTime.Now
            })
;        }
    }
}
