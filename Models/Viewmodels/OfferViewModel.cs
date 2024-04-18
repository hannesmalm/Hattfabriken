using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hattfabriken.Models.Viewmodels
{
    public class OfferViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Postal Code is required")]
        public int PostalCode { get; set; }

        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Hat type is required")]
        public int HatType { get; set; }

        [Required(ErrorMessage = "Material is required")]
        public string Material { get; set; }

        public List<string>? SpecialEffects { get; set; }

        public string? HatmakerComment { get; set; }

        [Required(ErrorMessage = "Material cost is required")]
        public double MaterialCost { get; set; }

        public double? SpecialEffectCost { get; set; }

        public double? ShippingCost { get; set; }

        [Required(ErrorMessage = "Estimated delivery date is required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EstimatedDeliveryDate { get; set; }

        [Required(ErrorMessage = "Total cost is required")]
        public double TotalCost { get; set; }

        public int Measurement { get; set; }

        public int Height { get; set; }

        public string Status { get; set; } = "Offer sent";

        public string DeliveryOrPickup { get; set; }

        public bool Urgent { get; set; }
    }
}
