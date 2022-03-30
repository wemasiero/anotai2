using Anotai.Data.Context;
using Anotai.Domain.Entities;
using Anotai.Domain.Interfaces;

namespace Anotai.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(AppDbContext appDbContext)
            : base(appDbContext) { }

        public IEnumerable<User> GetAll()
        {
            return Query(x => !x.IsDeleted);
        }
    }
}
