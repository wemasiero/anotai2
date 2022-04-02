using Anotai.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anotai.Data.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(100);
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Password).IsRequired();
        }
    }
}