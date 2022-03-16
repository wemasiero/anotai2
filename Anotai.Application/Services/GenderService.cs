using Anotai.Application.Interfaces;
using Anotai.Application.ViewModels;
using Anotai.Domain.Entities;
using Anotai.Domain.Interfaces;

namespace Anotai.Application.Services
{
    public class GenderService : IGenderService
    {
        private readonly IGenderRepository _genderRepository;

        public GenderService(IGenderRepository genderRepository)
        {
            _genderRepository = genderRepository;
        }

        public List<GenderViewModel> Get()
        {
            List<GenderViewModel> _genderViewModel = new List<GenderViewModel>();
            IEnumerable<Gender> _genders = _genderRepository.GetAll();

            foreach (Gender item in _genders)
                _genderViewModel.Add(new GenderViewModel { Id = item.Id, Description = item.Description, CreatedAt = (DateTime)item.CreatedAt, UpdatedAt = (DateTime)item.UpdatedAt });

            return _genderViewModel;
        }

    }
}
