using Anotai.Data.Context;
using Anotai.Domain.Entities;
using Anotai.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Anotai.Data.Repositories
{
    public class NoteRepository : Repository<Note>, INoteRepository
    {
        private readonly AppDbContext _appDbContext;

        public NoteRepository(AppDbContext appDbContext)
            : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Note> Get()
        {
            return _appDbContext.Notes
                                .Where(b => b.IsDeleted == false)
                                .Include(b => b.Book).ThenInclude(b => b.Gender)
                                .Include(b => b.Book).ThenInclude(b => b.User);
        }

        public IEnumerable<Note> GetById(int id)
        {
            return _appDbContext.Notes
                                .Where(b => b.IsDeleted == false && b.Id == id)
                                .Include(b => b.Book).ThenInclude(b => b.Gender)
                                .Include(b => b.Book).ThenInclude(b => b.User);
        }

        public IEnumerable<Note> GetByBookId(int bookId)
        {
            return _appDbContext.Notes
                                .Where(b => b.IsDeleted == false && b.BookId == bookId)
                                .Include(b => b.Book).ThenInclude(b => b.Gender)
                                .Include(b => b.Book).ThenInclude(b => b.User);
        }

        public IEnumerable<Note> GetByUserId(int userId)
        {
            return _appDbContext.Notes
                                .Where(b => b.IsDeleted == false &&
                                       b.Book.UserId == userId)
                                .Include(b => b.Book).ThenInclude(b => b.Gender)
                                .Include(b => b.Book).ThenInclude(b => b.User);
        }

        public IEnumerable<Note> GetByGenderId(int userId, int genderId)
        {
            return _appDbContext.Notes
                                .Where(b => b.IsDeleted == false &&
                                       b.Book.UserId == userId &&
                                       b.Book.GenderId == genderId)
                                .Include(b => b.Book).ThenInclude(b => b.Gender)
                                .Include(b => b.Book).ThenInclude(b => b.User);
        }

        public IEnumerable<Note> GetByAnnotation(int userId, string annotation)
        {
            return _appDbContext.Notes
                                .Where(b => b.IsDeleted == false &&
                                       b.Book.UserId == userId &&
                                       b.Annotation.Contains(annotation))
                                .Include(b => b.Book).ThenInclude(b => b.Gender)
                                .Include(b => b.Book).ThenInclude(b => b.User);
        }

        public IEnumerable<Note> GetByBookAuthor(int userId, string bookAuthor)
        {
            return _appDbContext.Notes
                                .Where(b => b.IsDeleted == false && 
                                       b.Book.UserId == userId &&
                                       b.Book.Author.Contains(bookAuthor))
                                .Include(b => b.Book).ThenInclude(b => b.Gender)
                                .Include(b => b.Book).ThenInclude(b => b.User);
        }

        public IEnumerable<Note> GetByBookDescription(int userId, string bookDescription)
        {
            return _appDbContext.Notes
                                .Where(b => b.IsDeleted == false &&
                                       b.Book.UserId == userId &&
                                       b.Book.Description.Contains(bookDescription))
                                .Include(b => b.Book).ThenInclude(b => b.Gender)
                                .Include(b => b.Book).ThenInclude(b => b.User);
        }

        public IEnumerable<Note> GetByBookTitle(int userId, string bookTitle)
        {
            return _appDbContext.Notes
                                .Where(b => b.IsDeleted == false &&
                                       b.Book.UserId == userId &&
                                       b.Book.Title.Contains(bookTitle))
                                .Include(b => b.Book).ThenInclude(b => b.Gender)
                                .Include(b => b.Book).ThenInclude(b => b.User);
        }
    }
}
