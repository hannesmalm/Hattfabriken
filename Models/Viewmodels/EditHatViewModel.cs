using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hattfabriken.Models
{
    public class EditHatViewModel
    {
        [Required]
        public int HatId { get; set; }

        [Required(ErrorMessage = "Please enter a hat name")]
        public string HatName { get; set;}
        public string MaterialName { get; set;}
        public string Description { get; set;}

        [Required(ErrorMessage = "Please enter a price")]
        public int Price { get; set;}
        public string SpecialEffects { get; set;}

        [Required(ErrorMessage = "Please enter an outer measurement")]
        public int OuterMeasurement { get; set;}
        public int Quantity { get; set; }

    }
}
