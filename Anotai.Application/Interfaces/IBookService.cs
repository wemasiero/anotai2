using Anotai.Application.ViewModels;

namespace Anotai.Application.Interfaces
{
    public interface IBookService
    {
        List<BookViewModel> GetAll();
        List<BookViewModel> GetById(int id);
        bool Post(BookViewModel bookViewModel);
        bool Put(BookViewModel bookViewModel);
        bool Delete(int id);
    }
}
