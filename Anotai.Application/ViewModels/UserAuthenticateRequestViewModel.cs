using System.ComponentModel.DataAnnotations;

namespace Anotai.Application.ViewModels
{
    public class UserAuthenticateRequestViewModel
    {
        [Required]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido")]
        public string Email { get; set; }
        [Required]
        [StringLength(16, MinimumLength = 4)]
        public string Password { get; set; }
    }
}