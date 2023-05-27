using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using WebApp.Models.Identities;

namespace WebApp.Models.Entities
{
    [PrimaryKey(nameof(UserId), nameof(AddressId))]
    public class AccountAddressEntity
    {
        [ForeignKey(nameof(User))]
        public string UserId { get; set; } = null!;
        public AppUser User { get; set; } = null!;

        [ForeignKey(nameof(Address))]
        public int AddressId { get; set; }
        public AddressEntity Address { get; set; } = null!;
    }
}
