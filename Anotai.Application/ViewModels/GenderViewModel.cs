using System.ComponentModel.DataAnnotations;

namespace Anotai.Application.ViewModels
{
    public class GenderViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe a descrição do gênero", AllowEmptyStrings = false)]
        public string Description { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime ?UpdatedAt { get; set; }
    }
}
