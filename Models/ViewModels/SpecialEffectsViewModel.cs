using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;


namespace Hattfabriken.Models.ViewModels
{
    public class SpecialEffectsViewModel
    {
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Effect Name is required")]
        [Display(Name = "Effect Name")]
        public string SpecialEffectName { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Price is required")]
        [Display(Name = "Price")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        //[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Quantity is required")]
        //public int MaterialQuantity { get; set; }
        //[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Supplier is required")]
        //public string MaterialSupplier { get; set; }
    }
}
