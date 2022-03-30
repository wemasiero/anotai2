using Anotai.Application.Interfaces;
using Anotai.Application.ViewModels;
using Anotai.Data.Repositories;
using Anotai.Domain.Entities;
using Anotai.Domain.Interfaces;
using AutoMapper;

namespace Anotai.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public List<UserViewModel> GetAll()
        {
            List<UserViewModel> _userViewModel = new List<UserViewModel>();
            IEnumerable<User> _users = _userRepository.GetAll();
            _userViewModel = _mapper.Map<List<UserViewModel>>(_users);

            return _userViewModel;
        }

        public UserViewModel GetById(int id)
        {
            User _user = _userRepository.Find(x => x.Id == id && !x.IsDeleted);

            if (_user == null)
                throw new Exception("Not Found!");

            return _mapper.Map<UserViewModel>(_user);
        }

        public bool Post(UserViewModel userViewModel)
        {
            User _user = _mapper.Map<User>(userViewModel);
            _userRepository.Create(_user);

            return true;
        }

        public bool Put(UserViewModel userViewModel)
        {
            User _user = _userRepository.Find(x => x.Id == userViewModel.Id && !x.IsDeleted);

            if (_user == null)
                throw new Exception("Not Found!");

            _user = _mapper.Map<User>(userViewModel);
            _userRepository.Update(_user);

            return true;
        }

        public bool Delete(int id)
        {
            User _user = _userRepository.Find(x => x.Id == id && !x.IsDeleted);

            if (_user == null)
                throw new Exception("Not Found!");

            return _userRepository.Delete(_user);
        }
    }
}
