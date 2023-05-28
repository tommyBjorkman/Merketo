using System.ComponentModel.DataAnnotations;
using WebApp.Models.Interfaces;

namespace WebApp.Models.ViewModels
{
    public class AccountRegisterViewModel : IAccountRegistration
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You need to type in a first name.")]
        public string FirstName { get; set; } = null!;


        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You need to type in a last name.")]
        public string LastName { get; set; } = null!;



        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "You need to type in a Email address.")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^[a-zA-Z0-9._%]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Email address is not valid")]
        public string Email { get; set; } = null!;


        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }


        [Display(Name = "Company Name (optional)")]
        public string? CompanyName { get; set; }


        [Display(Name = "Password")]
        [Required(ErrorMessage = "You need to type in a password.")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[A-Z](?=.*[a-z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).{8,}$"), ErrorMessage = "You need to type a valid password"]
        public string Password { get; set; } = null!;


        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Password does not match")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ComparePassword { get; set; } = null!;


        [Display(Name = "Street Name")]
        [Required(ErrorMessage = "Street name is required")]
        public string StreetName { get; set; } = null!;


        [Display(Name = "Postal Code")]
        [Required(ErrorMessage = "Postal code is required")]
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; } = null!;


        [Display(Name = "City")]
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; } = null!;


        [Display(Name = "Country")]
        public string? Country { get; set; }



        [Display(Name = "Profile Image")]
        [DataType(DataType.Upload)]
        public IFormFile? ProfileImage { get; set; }
    }
}
