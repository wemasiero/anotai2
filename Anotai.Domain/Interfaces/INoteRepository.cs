using Anotai.Domain.Entities;

namespace Anotai.Domain.Interfaces
{
    public interface INoteRepository : IRepository<Note>
    {
        IEnumerable<Note> Get();
        IEnumerable<Note> GetById(int id);
        IEnumerable<Note> GetByBookId(int bookId);
        IEnumerable<Note> GetByUserId(int userId);
        IEnumerable<Note> GetByGenderId(int userId, int genderId);
        IEnumerable<Note> GetByAnnotation(int userId, string annotation);
        IEnumerable<Note> GetByBookAuthor(int userId, string bookAuthor);
        IEnumerable<Note> GetByBookDescription(int userId, string bookDescription);
        IEnumerable<Note> GetByBookTitle(int userId, string bookTitle);
    }
}
