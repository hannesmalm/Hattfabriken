using System.ComponentModel.DataAnnotations.Schema;

namespace Hattfabriken.Models

{
    public class AddHatViewModel
    {
        public int HatId { get; set; }
        public string HatName { get; set; }
        public string? HatType { get; set; }
        public string MaterialName { get; set; }
        public string Description { get; set; }
        public string? SpecialEffects { get; set; }
        public int OuterMeasurement { get; set; }
        public int Quantity { get; set; }
        public IFormFile? HatImage { get; set; }
        public double MaterialCost { get; set; }

        public double? SpecialEffectCost { get; set; }
    }
}
