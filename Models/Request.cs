﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Permissions;

namespace Hattfabriken.Models
{
    public class Request
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Hat")]
        public string? HatType { get; set; }

        public string? Material { get; set; }

        public int? Measurement { get; set; }

        public int? OuterMeasurement { get; set; }

        public int? Height { get; set; }

        public string? Commentary { get; set; }

        [ForeignKey("SpecialEffects")]
        public string? SpecialEffects { get; set; }

        public string Adress { get; set; }

        public int PostalCode { get; set; }

        public string PhoneNumber { get; set; }

        public string Country { get; set; }

        [ForeignKey("Customer")]
        public string Email { get; set; }

        public string Name { get; set; }
         
        [ForeignKey("Image")]
        public byte[]? RequestImage { get; set; }

        public string Status { get; set; } = "Pending";

        public DateTime Date { get; set; }

        public bool Delivery { get; set; }

        public bool Urgent { get; set; }
    }
}