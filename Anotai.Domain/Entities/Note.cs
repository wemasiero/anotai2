using Anotai.Domain.Models;

namespace Anotai.Domain.Entities
{
    public class Note : Entity
    {
        public string Annotation { get; set; }
        public string? Reference { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}