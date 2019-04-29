using System;
using System.ComponentModel.DataAnnotations;

namespace NetcrackerNews.Models
{
    /// <summary>
    /// Новостная статья
    /// </summary>
    public class Article
    {
        public int ArticleId { get; set; }
        [Required(ErrorMessage = "Заголовок не может быть пустым.")]
        [MaxLength(100, ErrorMessage = "Длина заголовка не может превышать 100 символов.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Текст статьи не может быть пустым.")]
        public string Text { get; set; }
        [Required]
        public DateTime TimeStamp { get; set; }
    }
}
