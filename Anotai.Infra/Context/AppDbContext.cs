using Anotai.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Anotai.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) 
        {

        }

        public DbSet<Gender> Genders { get; set; }
    }
}
