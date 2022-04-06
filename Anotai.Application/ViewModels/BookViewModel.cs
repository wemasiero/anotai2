using Anotai.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Anotai.Application.ViewModels
{
    public class BookViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o título do livro", AllowEmptyStrings = false)]
        public string Title { get; set; }
        public string? Author { get; set; }
        public string? Publisher { get; set; }
        public int? Year { get; set; }
        public string? Description { get; set; }
        public string? ISBN { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        [Required]
        public int GenderId { get; set; }
        public Gender? Gender { get; set; }
        [Required]
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
