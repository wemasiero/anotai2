using Anotai.Application.Interfaces;
using Anotai.Application.ViewModels;
using Anotai.Domain.Entities;
using Anotai.Domain.Interfaces;
using AutoMapper;

namespace Anotai.Application.Services
{
    public class GenderService : IGenderService
    {
        private readonly IGenderRepository _genderRepository;
        private readonly IMapper _mapper;

        public GenderService(IGenderRepository genderRepository, IMapper mapper)
        {
            _genderRepository = genderRepository;
            _mapper = mapper;
        }

        public List<GenderViewModel> GetAll()
        {
            List<GenderViewModel> _genderViewModel = new List<GenderViewModel>();
            IEnumerable<Gender> _genders = _genderRepository.GetAll();
            _genderViewModel = _mapper.Map<List<GenderViewModel>>(_genders);

            return _genderViewModel;
        }

        public bool Post(GenderViewModel genderViewModel)
        {
            Gender _gender = _mapper.Map<Gender>(genderViewModel);
            _genderRepository.Create(_gender);

            return true;
        }

        public GenderViewModel GetById(int id)
        {
            Gender _gender = _genderRepository.Find(x => x.Id == id && !x.IsDeleted);

            if (_gender == null)
                throw new Exception("Not Found!");

            return _mapper.Map<GenderViewModel>(_gender);
        }

        public bool Put(GenderViewModel genderViewModel)
        {
            Gender _gender = _genderRepository.Find(x => x.Id == genderViewModel.Id && !x.IsDeleted);
            
            if (_gender == null)
                throw new Exception("Not Found!");

            _gender = _mapper.Map<Gender>(genderViewModel);
            _genderRepository.Update(_gender);

            return true;
        }

        public bool Delete(int id)
        {
            Gender _gender = _genderRepository.Find(x => x.Id == id && !x.IsDeleted);

            if (_gender == null)
                throw new Exception("Not Found!");            

            return _genderRepository.Delete(_gender);
        }

    }
}
