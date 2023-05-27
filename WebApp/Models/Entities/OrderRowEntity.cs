﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models.Entities
{
    [PrimaryKey(nameof(OrderId), nameof(ItemId))]
    public class OrderRowEntity
    {
        [ForeignKey(nameof(Order))]
        public int OrderId { get; set; }
        public string ItemId { get; set; } = null!;
        public int Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal ItemPrice { get; set; }
        public OrderEntity Order { get; set; } = null!;
    }
}
