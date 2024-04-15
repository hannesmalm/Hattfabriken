using System.ComponentModel.DataAnnotations.Schema;

namespace Hattfabriken.Models
{
    public class Order
    {
        public int Id { get; set; }
        [ForeignKey("Request")]
        public int? RequestId { get; set; }
        [ForeignKey("Hatt")]
        public int? HatId { get; set; }
        public string? Material { get; set; }
        public int? Measurement { get; set; }
        public int? Height { get; set; }
        public string? Commentary { get; set; }
        public List<string>? SpecialEffects { get; set; }
        public string Adress { get; set; }
        public int PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
        [ForeignKey("Customer")]
        public string Email { get; set; }
        public string Name { get; set; }
        public string Status { get; set; } = "Pending";
        public DateTime Date { get; set; }
        public bool Invoice { get; set; }
        public bool Waybill { get; set; }
    }
}
