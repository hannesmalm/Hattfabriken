using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hattfabriken.Models
{
    public class SpecialEffects
    {
        [Key]
        public string SpecialEffectName { get; set; }

        public decimal Price { get; set; }
    }

}