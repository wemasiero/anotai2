using Anotai.Application.ViewModels;

namespace Anotai.Application.Interfaces
{
    public interface INoteService
    {
        List<NoteViewModel> Get();
        List<NoteViewModel> GetById(int id);
        List<NoteViewModel> GetByBookId(int bookId);
        List<NoteViewModel> GetByUserId(int userId);
        List<NoteViewModel> GetByGenderId(int userId, int genderId);
        List<NoteViewModel> GetByAnnotation(int userId, string annotation);
        List<NoteViewModel> GetByBookAuthor(int userId, string bookAuthor);
        List<NoteViewModel> GetByBookDescription(int userId, string bookDescription);
        List<NoteViewModel> GetByBookTitle(int userId, string bookTitle);
        bool Post(NoteViewModel noteViewModel);
        bool Put(NoteViewModel noteViewModel);
        bool Delete(int id);
    }
}
