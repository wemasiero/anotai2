using Anotai.Domain.Entities;

namespace Anotai.Domain.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        IEnumerable<Book> GetAll();
        IEnumerable<Book> GetById(int id);
    }
}
