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
    }
}
