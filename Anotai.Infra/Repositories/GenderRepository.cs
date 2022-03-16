using Anotai.Data.Context;
using Anotai.Domain.Entities;
using Anotai.Domain.Interfaces;

namespace Anotai.Data.Repositories
{
    public class GenderRepository : Repository<Gender>, IGenderRepository
    {
        public GenderRepository(AppDbContext appDbContext)
            : base(appDbContext){ }

        public IEnumerable<Gender> GetAll()
        {
            return Query(x => !x.IsDeleted);
        }
    }
}
