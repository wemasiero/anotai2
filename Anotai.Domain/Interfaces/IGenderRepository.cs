using Anotai.Domain.Entities;

namespace Anotai.Domain.Interfaces
{
    public interface IGenderRepository : IRepository<Gender>
    {
        IEnumerable<Gender> GetAll();
    }
}
