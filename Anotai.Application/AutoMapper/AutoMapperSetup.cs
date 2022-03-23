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
            #endregion

            #region DomainToViewModel
            CreateMap<Gender, GenderViewModel>();
            #endregion
        }
    }
}
