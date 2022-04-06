using Anotai.Domain.Entities;

namespace Anotai.Application.ViewModels
{
    public class NoteViewModel
    {
        public int Id { get; set; }
        public string Annotation { get; set; }
        public string? Reference { get; set; }
        public int BookId { get; set; }
        public Book? Book { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
    }
}
