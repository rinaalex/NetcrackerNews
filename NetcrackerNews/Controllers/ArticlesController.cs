using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetcrackerNews.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NetcrackerNews.Controllers
{
    [Route("api/[controller]")]
    public class ArticlesController : Controller
    {
        NewsContext context;
        public ArticlesController(NewsContext context)
        {
            this.context = context;
        }

        // GET: api/articles
        [HttpGet]
        public IEnumerable<Article> Get()
        {
            return context.Articles.OrderByDescending(p=>p.TimeStamp).ToList();
        }

        // GET api/articles/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Article article = context.Articles.FirstOrDefault(p => p.ArticleId == id);
            if(article==null)
            {
                return NotFound();
            }
            return new ObjectResult(article);
        }

        // POST api/articles
        [HttpPost]
        public IActionResult Post([FromBody]Article article)
        {
            if(article==null)
            {
                return BadRequest();
            }
            article.TimeStamp = DateTime.UtcNow;
            context.Articles.Add(article);
            context.SaveChanges();
            return Ok(article);
        }

        // PUT api/articles/
        [HttpPut]
        public IActionResult Put([FromBody]Article article)
        {
            if(article==null)
            {
                return BadRequest();
            }
            if (!context.Articles.Any(p => p.ArticleId == article.ArticleId))
            {
                return NotFound();
            }
            context.Update(article);
            context.SaveChanges();
            return Ok(article);
        }

        // DELETE api/articles/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Article article = context.Articles.FirstOrDefault(p => p.ArticleId == id);
            if(article==null)
            {
                return NotFound();
            }
            context.Remove(article);
            context.SaveChanges();
            return Ok(article);
        }
    }
}
