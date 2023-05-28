using Microsoft.AspNetCore.Identity;
using WebApp.Models.Entities;
using WebApp.Models.Interfaces;

namespace WebApp.Models.Identities
{
    public class AppUser : IdentityUser, IAccountInformation, ICompanyInformation, IProfileImage
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? ProfileImage { get; set; }
        public string? CompanyName { get; set; }
        public ICollection<AccountAddressEntity> Addresses { get; set; } = new HashSet<AccountAddressEntity>();
        public ICollection<OrderEntity> Orders { get; set; } = new HashSet<OrderEntity>();
    }
}
