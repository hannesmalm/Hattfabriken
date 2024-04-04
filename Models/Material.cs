using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hattfabriken.Models
{
    public class Material
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]

        public string MaterialName { get; set; }
        [Required]

        public int MaterialQuantity { get; set; }
        public string MaterialSupplier { get; set; }
        public int Price { get; set; }
    }
}
