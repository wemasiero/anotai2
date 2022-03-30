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

        public IEnumerable<Book> GetAll()
        {
            return _appDbContext.Books
                                .Where(b => b.IsDeleted == false)
                                .Include(b => b.Gender)
                                .Include(b => b.User);
        }

        public IEnumerable<Book> GetById(int id)
        {
            return _appDbContext.Books
                                .Where(b => b.IsDeleted == false && b.Id == id)
                                .Include(b => b.Gender)
                                .Include(b => b.User);
        }
    }
}
