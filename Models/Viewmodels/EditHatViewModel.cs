using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hattfabriken.Models
{
    public class EditHatViewModel
    {
        public int HatId { get; set; }
        [Required(ErrorMessage = "Hat name is required")]
        public string HatName { get; set; }
        public string MaterialName { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Price is required")]
        public int Price { get; set; }
        public string? SpecialEffects { get; set; }
        [Required(ErrorMessage = "Outer measurement is required")]
        public int OuterMeasurement { get; set; }
        [Required(ErrorMessage = "Quantity is required")]
        public int Quantity { get; set; }
        public IFormFile? HatImage { get; set; }

    }
}