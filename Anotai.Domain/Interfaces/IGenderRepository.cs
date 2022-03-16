using Anotai.Domain.Entities;

namespace Anotai.Domain.Interfaces
{
    public interface IGenderRepository
    {
        IEnumerable<Gender> GetAll();
    }
}
