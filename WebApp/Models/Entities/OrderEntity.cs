﻿using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebApp.Models.Identities;

namespace WebApp.Models.Entities
{
    public class OrderEntity
    {
        public int Id { get; set; }
        public string UserId { get; set; } = null!;
        public DateTime OrderDate { get; set; } = DateTime.Now;

        [Column(TypeName = "money")]
        public decimal TotalAmount { get; set; }
        public AppUser User { get; set; } = null!;
    }
}
