using Anotai.Data.Extensions;
using Anotai.Data.Mappings;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GenderMap());
            modelBuilder.ApplyGlobalConfiguration();
            modelBuilder.SeedData();

            base.OnModelCreating(modelBuilder);
        }
    }
}
