using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Models.Entities
{
    [PrimaryKey(nameof(UserId), nameof(AddressId))]
    public class AccountAddressEntity
    {
        [ForeignKey(nameof(Account))]
        public string UserId { get; set; } = null!;
        public AccountEntity Account { get; set; } = null!;

        [ForeignKey(nameof(Address))]
        public int AddressId { get; set; }
        public AddressEntity Address { get; set; } = null!;
    }
}
