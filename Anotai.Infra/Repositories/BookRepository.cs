using Anotai.Data.Context;
using Anotai.Domain.Entities;
using Anotai.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Anotai.Data.Repositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        private readonly AppDbContext _appDbContext;

        public BookRepository(AppDbContext appDbContext)
            : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Book> Get()
        {
            return _appDbContext.Books
                                .Where(b => b.IsDeleted == false)
                                .Include(b => b.Gender)
                                .Include(b => b.User);
        }

        public IEnumerable<Book> GetById(int id)
        {
            return _appDbContext.Books
                                .Where(b => !b.IsDeleted && 
                                             b.Id == id)
                                .Include(b => b.Gender)
                                .Include(b => b.User);
        }

        public IEnumerable<Book> GetByUserId(int id)
        {
            return _appDbContext.Books
                                .Where(b => b.IsDeleted == false && 
                                            b.UserId == id)
                                .Include(b => b.Gender)
                                .Include(b => b.User);
        }

        public IEnumerable<Book> GetByGenderId(int id)
        {
            return _appDbContext.Books
                                .Where(b => b.IsDeleted == false && 
                                            b.GenderId == id)
                                .Include(b => b.Gender)
                                .Include(b => b.User);
        }

        public IEnumerable<Book> GetByGenderIdUserId(int genderId, int userId)
        {
            return _appDbContext.Books
                                .Where(b => b.IsDeleted == false && 
                                            b.GenderId == genderId && 
                                            b.UserId == userId)
                                .Include(b => b.Gender)
                                .Include(b => b.User);
        }

        public IEnumerable<Book> GetByUserIdBookTitle(int userId, string bookTitle)
        {
            return _appDbContext.Books
                                .Where(b => b.IsDeleted == false && 
                                            b.UserId == userId && 
                                            b.Title.Contains(bookTitle));
        }

        public IEnumerable<Book> GetByUserIdBookDescription(int userId, string bookDescription)
        {
            return _appDbContext.Books
                                .Where(b => b.IsDeleted == false &&
                                            b.UserId == userId &&
                                            b.Description.Contains(bookDescription));
        }

        public IEnumerable<Book> GetByUserIdBookAuthor(int userId, string bookAuthor)
        {
            return _appDbContext.Books
                                .Where(b => b.IsDeleted == false &&
                                            b.UserId == userId &&
                                            b.Author.Contains(bookAuthor));
        }

        public IEnumerable<Book> GetByUserIdBookISBN(int userId, string bookISBN)
        {
            return _appDbContext.Books
                                .Where(b => b.IsDeleted == false &&
                                            b.UserId == userId &&
                                            b.ISBN.Contains(bookISBN));
        }

        public IEnumerable<Book> GetByUserIdGenderDescription(int userId, string genderDescription)
        {
            return _appDbContext.Books
                                .Where(b => b.IsDeleted == false && 
                                            b.UserId == userId && 
                                            b.Gender.Description.Contains(genderDescription))
                                .Include(b => b.Gender);
        }
    }
}