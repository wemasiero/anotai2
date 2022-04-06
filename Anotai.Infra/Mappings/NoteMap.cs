using Anotai.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anotai.Data.Mappings
{
    public class NoteMap : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Annotation).HasMaxLength(500);
        }
    }
}
