namespace WebApp.Models.ViewModels
{
    public class AccountRegisterViewModel
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public string? CompanyName { get; set; }
        public string? ProfileImage { get; set; }
    }
}
