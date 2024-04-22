using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hattfabriken.Models
{
    public class EditHatViewModel
    {
        public int HatId { get; set; }
        public string HatName { get; set;}
        public string MaterialName { get; set;}
        public string Description { get; set;}
        public int Price { get; set;}
        public string? SpecialEffects { get; set;}
        public int OuterMeasurement { get; set;}
        public int Quantity { get; set; }

    }
}
