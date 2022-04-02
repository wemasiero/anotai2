using Anotai.Application.ViewModels;

namespace Anotai.Application.Interfaces
{
    public interface IBookService
    {
        List<BookViewModel> Get();
        List<BookViewModel> GetById(int id);
        List<BookViewModel> GetByUserId(int userId);
        List<BookViewModel> GetByGenderId(int genderId);
        List<BookViewModel> GetByGenderIdUserId(int genderId, int userId);
        List<BookViewModel> GetByUserIdBookTitle(int userId, string bookTitle);
        List<BookViewModel> GetByUserIdBookDescription(int userId, string bookDescription);
        List<BookViewModel> GetByUserIdBookAuthor(int userId, string bookAuthor);
        List<BookViewModel> GetByUserIdBookISBN(int userId, string bookISBN);
        List<BookViewModel> GetByUserIdGenderDescription(int userId, string genderDescription);
        bool Post(BookViewModel bookViewModel);
        bool Put(BookViewModel bookViewModel);
        bool Delete(int id);
    }
}
