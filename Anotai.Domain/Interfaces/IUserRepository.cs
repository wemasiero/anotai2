using Anotai.Domain.Entities;

namespace Anotai.Domain.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        IEnumerable<User> Get();
    }
}
