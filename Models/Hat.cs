using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Hattfabriken.Models
{
    public class Hatt
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int HatId { get; set; }

        [Required(ErrorMessage = "Please enter a hat name")]
        public string HatName { get; set; }
       
        [ForeignKey("Material")]
        public string MaterialName { get; set; }
        public virtual Material Material { get; set; }
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter a price")]
        public int Price { get; set; }
        public string SpecialEffects { get; set; }

        [Required(ErrorMessage = "Please enter an outer measurement")]
        public int OuterMeasurement {  get; set; }
    }
}
