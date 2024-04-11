using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hattfabriken.Models
{
    public class Material
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]

        public string MaterialName { get; set; }
        

        [Required(ErrorMessage = "Quantity is required")]
        public int MaterialQuantity { get; set; }
        [Required(ErrorMessage = "Supplier is required")]
        public string MaterialSupplier { get; set; }
        [Required(ErrorMessage = "Price is required")]
        public int Price { get; set; }

        public bool IsConfirmed { get; set; }
    }
}
