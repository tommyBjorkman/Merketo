using WebApp.Models.Interfaces;

namespace WebApp.Models.ViewModels
{
    public class AccountRegisterViewModel : IAccountRegistration
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? ProfileImage { get; set; }
        public string Email { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public string? CompanyName { get; set; }
        public string Password { get; set; } = null!;
        public string ComparePassword { get; set; } = null!;
        public string StreetName { get; set; } = null!;
        public string PostalCode { get; set; } = null!;
        public string City { get; set; } = null!;
        public string? Country { get; set; }
    }
}
