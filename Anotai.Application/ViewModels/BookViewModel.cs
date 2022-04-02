using Anotai.Domain.Entities;

namespace Anotai.Application.ViewModels
{
    public class BookViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Author { get; set; }
        public string? Publisher { get; set; }
        public int? Year { get; set; }
        public string? Description { get; set; }
        public string? ISBN { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public int GenderId { get; set; }
        public Gender? Gender { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
