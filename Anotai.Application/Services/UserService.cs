using Anotai.Application.Interfaces;
using Anotai.Application.ViewModels;
using Anotai.Domain.Entities;
using Anotai.Domain.Interfaces;
using AutoMapper;
using System.Security.Cryptography;
using System.Text;
using Template.Auth.Services;

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

        public List<UserViewModel> Get()
        {
            List<UserViewModel> _userViewModel = new List<UserViewModel>();
            IEnumerable<User> _users = _userRepository.Get();
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
            _user.Password = EncryptPassword(_user.Password);
            _userRepository.Create(_user);

            return true;
        }

        public bool Put(UserViewModel userViewModel)
        {
            userViewModel.Password = EncryptPassword(userViewModel.Password);
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

        public UserAuthenticateResponseViewModel Authenticate(UserAuthenticateRequestViewModel user)
        {
            user.Password = EncryptPassword(user.Password);
            User _user = _userRepository.Find(x => !x.IsDeleted && x.Email.ToLower() == user.Email.ToLower() && x.Password == user.Password);

            if (_user == null)
                throw new Exception("Not Found!");

            return new UserAuthenticateResponseViewModel(_mapper.Map<UserViewModel>(_user), TokenService.GenerateToken(_user));
        }

        public string EncryptPassword(string password)
        {
            HashAlgorithm sha = new SHA1CryptoServiceProvider();

            byte[] encryptedPassword = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var caracter in encryptedPassword)
            {
                stringBuilder.Append(caracter.ToString("X2"));
            }

            return stringBuilder.ToString();
        }
    }
}
