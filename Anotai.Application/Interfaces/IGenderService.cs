using Anotai.Application.ViewModels;

namespace Anotai.Application.Interfaces
{
    public interface IGenderService
    {
        List<GenderViewModel> GetAll();
        bool Post(GenderViewModel genderViewModel);
        GenderViewModel GetById(int id);
        bool Put(GenderViewModel genderViewModel);
        bool Delete(int id);
    }
}
