using Anotai.Domain.Entities;

namespace Anotai.Domain.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        IEnumerable<Book> Get();
        IEnumerable<Book> GetById(int id);
        IEnumerable<Book> GetByUserId(int userId);
        IEnumerable<Book> GetByGenderId(int genderId);
        IEnumerable<Book> GetByGenderIdUserId(int genderId, int userId);
        IEnumerable<Book> GetByUserIdBookTitle(int userId, string bookTitle);
        IEnumerable<Book> GetByUserIdBookDescription(int userId, string bookDescription);
        IEnumerable<Book> GetByUserIdBookAuthor(int userId, string bookAuthor);
        IEnumerable<Book> GetByUserIdBookISBN(int userId, string bookISBN);
        IEnumerable<Book> GetByUserIdGenderDescription(int userId, string genderDescription);
    }
}
