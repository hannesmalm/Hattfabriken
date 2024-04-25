using System.ComponentModel.DataAnnotations.Schema;

namespace Hattfabriken.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string? HatType { get; set; }
        public string? Material { get; set; }
        public int? Measurement { get; set; }
        public int? Height { get; set; }
        public string? Commentary { get; set; }
        public string? SpecialEffects { get; set; }

        [ForeignKey("Image")]
        public byte[]? HatImage { get; set; }
        public double MaterialCost { get; set; }
        public double? SpecialEffectCost { get; set; }
        public double? ShippingCost { get; set; }
        public string Address { get; set; }
        public int PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }

        [ForeignKey("Customer")]
        public string Email { get; set; }
        public string Name { get; set; }
        public string Status { get; set; } = "To-Do";
        public DateTime EstimatedDate { get; set; }
        public string? Maker { get; set; }
        public bool Delivery { get; set; }
        public bool Urgent { get; set; }

    }
}
