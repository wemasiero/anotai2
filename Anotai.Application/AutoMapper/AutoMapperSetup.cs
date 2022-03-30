using Anotai.Application.ViewModels;
using Anotai.Domain.Entities;
using AutoMapper;

namespace Anotai.Application.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {
            #region ViewModelToDomain
            CreateMap<GenderViewModel, Gender>();
            CreateMap<UserViewModel, User>();
            CreateMap<BookViewModel, Book>();
            #endregion

            #region DomainToViewModel
            CreateMap<Gender, GenderViewModel>();
            CreateMap<User, UserViewModel>();
            CreateMap<Book, BookViewModel>();
            #endregion
        }
    }
}
