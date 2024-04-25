using System.ComponentModel.DataAnnotations.Schema;

namespace Hattfabriken.Models.DTOs
{
    public class OrderData
    {
        public int Id { get; set; }
        public string? HatType { get; set; }
        public string? Material { get; set; }
        public int? Measurement { get; set; }
        public int? Height { get; set; }
        public string? Commentary { get; set; }
        public string? SpecialEffects { get; set; }
        public byte[]? HatImage { get; set; }
        public DateTime EstimatedDate { get; set; }
        public bool Urgent { get; set; }
    }
}
