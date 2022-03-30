using Anotai.Domain.Entities;
using Anotai.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Anotai.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder ApplyGlobalConfiguration(this ModelBuilder modelbuilder)
        {
            foreach (IMutableEntityType entityType in modelbuilder.Model.GetEntityTypes())
            {
                foreach(IMutableProperty property in entityType.GetProperties())
                {
                    switch (property.Name){

                        case nameof(Entity.Id):
                            property.IsKey();
                            break;

                        case nameof(Entity.IsDeleted):
                            property.IsNullable = false;
                            property.SetDefaultValue(false);
                            break;

                        case nameof(Entity.CreatedAt):
                            property.IsNullable = false;
                            property.SetDefaultValue(DateTime.Now);
                            break;

                        case nameof(Entity.UpdatedAt):
                            property.IsNullable = true;
                            break;

                        default:
                            break;
                    }
                }
            }

            return modelbuilder;
        }
    
            public static ModelBuilder SeedData(this ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<User>()
                .HasData(
                    new User { Id = 1, Name = "master", Email = "wemasiero@gmail.com", Password = "Wand$050483", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null }
                ); ;

            modelbuilder.Entity<Gender>()
                .HasData(
                    new Gender { Id = 1, Description = "AÇÃO E AVENTURA", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null },
                    new Gender { Id = 2, Description = "ARTE E FOTOGRAFIA", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null },
                    new Gender { Id = 3, Description = "AUTOAJUDA", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null },
                    new Gender { Id = 4, Description = "BIOGRAFIA", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null },
                    new Gender { Id = 5, Description = "CONTO", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null },
                    new Gender { Id = 6, Description = "CRIMES REAIS", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null },
                    new Gender { Id = 7, Description = "DISTOPIA", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null },
                    new Gender { Id = 8, Description = "ENSAIOS", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null },
                    new Gender { Id = 9, Description = "FANTASIA", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null },
                    new Gender { Id = 10, Description = "FICÇÃO CIENTÍFICA", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null },
                    new Gender { Id = 11, Description = "FICÇÃO CONTEMPORÂNEA", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null },
                    new Gender { Id = 12, Description = "FICÇÃO FEMININA", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null },
                    new Gender { Id = 13, Description = "FICÇÃO HISTÓRICA", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null },
                    new Gender { Id = 14, Description = "FICÇÃO POLICIAL", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null },
                    new Gender { Id = 15, Description = "GASTRONOMIA", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null },
                    new Gender { Id = 16, Description = "GÊNEROS DE FICÇÃO", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null },
                    new Gender { Id = 17, Description = "GÊNEROS DE NÃO FICÇÃO", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null },
                    new Gender { Id = 18, Description = "GRAPHIC NOVEL", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null },
                    new Gender { Id = 19, Description = "GUIAS & COMO FAZER ", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null },
                    new Gender { Id = 20, Description = "HISTÓRIA", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null },
                    new Gender { Id = 21, Description = "HORROR", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null },
                    new Gender { Id = 22, Description = "HUMANIDADES E CIÊNCIAS SOCIAIS", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null },
                    new Gender { Id = 23, Description = "HUMOR", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null },
                    new Gender { Id = 24, Description = "INFANTIL", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null },
                    new Gender { Id = 25, Description = "LGBTQ+", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null },
                    new Gender { Id = 26, Description = "MEMÓRIAS E AUTOBIOGRAFIA", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null },
                    new Gender { Id = 27, Description = "NEW ADULT – NOVO ADULTO ", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null },
                    new Gender { Id = 28, Description = "PATERNIDADE E FAMÍLIA", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null },
                    new Gender { Id = 29, Description = "REALISMO MÁGICO", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null },
                    new Gender { Id = 30, Description = "RELIGIÃO E ESPIRITUALIDADE", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null },
                    new Gender { Id = 31, Description = "ROMANCE", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null },
                    new Gender { Id = 32, Description = "TECNOLOGIA E CIÊNCIA", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null },
                    new Gender { Id = 33, Description = "THRILLER E SUSPENSE", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null },
                    new Gender { Id = 34, Description = "VIAJEM", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null },
                    new Gender { Id = 35, Description = "YOUNG ADULT – JOVEM ADULTO", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = null }
                );

            return modelbuilder;
        }
    }
}
