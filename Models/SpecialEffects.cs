using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hattfabriken.Models
{
    public class SpecialEffects
    {
        [Key]
        public string SpecialEffectName { get; set; }

        //[Required(ErrorMessage = "Quantity is required")]
        //public int MaterialQuantity { get; set; }
        //[Required(ErrorMessage = "Supplier is required")]
        //public string MaterialSupplier { get; set; }

        public decimal Price { get; set; }
    }
}
