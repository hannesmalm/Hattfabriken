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
        public string HatName { get; set; }
        //[ForeignKey("Material")]
        public string MaterialName {  get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string SpecialEffects { get; set; }
        public int OuterMeasurement {  get; set; }
    }
}
