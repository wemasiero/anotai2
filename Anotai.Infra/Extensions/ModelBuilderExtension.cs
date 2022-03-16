using Anotai.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Anotai.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<Gender>()
                .HasData(
                    new Gender { Id = Guid.NewGuid(), Description = '' }
                );

            return builder;
        }
    }
}
