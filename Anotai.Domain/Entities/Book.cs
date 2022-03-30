using Anotai.Domain.Models;

namespace Anotai.Domain.Entities
{
    public class Book : Entity
    {
        public string Title { get; set; }
        public string? Author { get; set; }
        public string? Publisher { get; set; }
        public int? Year { get; set; }
        public string? Description { get; set; }
        public string? ISBN { get; set; }
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
