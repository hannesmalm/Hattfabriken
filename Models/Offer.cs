﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Permissions;

namespace Hattfabriken.Models
{
    public class Offer
    {
        [Key]
        public int OffertId { get; set; }

        [ForeignKey("Hat")]
        public required string HatType { get; set; }

        public required string Name { get; set; }

        public required string Email { get; set; }

        public string? PhoneNumber { get; set; }

        public string Address { get; set; }

        public int PostalCode { get; set; }

        public string Country { get; set; }

        public required double MaterialCost { get; set; }

        public double? SpecialEffectCost { get; set; }

        public double? ShippingCost { get; set; }

        public required DateTime DateCreated { get; set; }

        [Required(ErrorMessage = "Choose a date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public required DateTime EstimatedDeliveryDate { get; set; }

        public required double TotalCost { get; set; }

        public string Material { get; set; }

        public int Measurement {  get; set; }

        public int OuterMeasurement { get; set; }

        public int Height { get; set; }

        public string? HatmakerComment { get; set; }

        [ForeignKey("SpecialEffects")]
        public string? SpecialEffect { get; set; }

        public string Status { get; set; } = "Offer sent";

        public bool Delivery { get; set; }

        public bool Urgent { get; set; }

        [ForeignKey("Image")]
        public byte[]? HatImage { get; set; }
    }
}


