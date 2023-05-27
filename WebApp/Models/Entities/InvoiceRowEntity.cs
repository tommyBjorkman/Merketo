using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models.Entities
{
    [PrimaryKey(nameof(InvoiceId), nameof(ItemId))]
    public class InvoiceRowEntity
    {
        [ForeignKey(nameof(Invoice))]
        public int InvoiceId { get; set; }
        public string ItemId { get; set; } = null!;
        public int Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal ItemPrice { get; set; }
        public InvoiceEntity Invoice { get; set; } = null!;
    }
}
