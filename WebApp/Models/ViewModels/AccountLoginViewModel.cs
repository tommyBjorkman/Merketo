using System.ComponentModel.DataAnnotations;
using WebApp.Models.Interfaces;

namespace WebApp.Models.ViewModels
{
    public class AccountLoginViewModel : ILoginInformation
    {
        [Display(Name = "Password")]
        [Required(ErrorMessage = "You need to type in a password.")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;


        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "You need to type in a valid Email address.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;


        [Display(Name = "Keep me logged in")]
        public bool RememberMe { get; set; }
    }
}
