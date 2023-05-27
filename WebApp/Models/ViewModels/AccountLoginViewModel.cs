using WebApp.Models.Interfaces;

namespace WebApp.Models.ViewModels
{
    public class AccountLoginViewModel : ILoginInformation
    {
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public bool RememberMe { get; set; }
    }
}
