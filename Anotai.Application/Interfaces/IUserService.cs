using Anotai.Application.ViewModels;

namespace Anotai.Application.Interfaces
{
    public interface IUserService
    {
        List<UserViewModel> GetAll();
        UserViewModel GetById(int id);
        bool Post(UserViewModel userViewModel);
        bool Put(UserViewModel userViewModel);
        bool Delete(int id);
    }
}
