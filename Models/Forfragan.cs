using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Permissions;

namespace Hattfabriken.Models
{
    public class Forfragan
    {
        [Key]
        public int ForfraganID {  get; set; }
        [ForeignKey("Hatt")]
        public int HatId { get; set; }
        [Required]
        public string Material { get; set; }
        [Required]
        public int Matt { get; set; }
        [Required]
        public int Hojd { get; set; }
        public string Kommentar { get; set; }
        public string SpecialEffekter { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public int Postnummer { get; set; }
        [Required(ErrorMessage = "Telefonnumret är obligatoriskt.")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Telefonnumret får bara innehålla siffror.")]
        public int Telefonnummer { get; set; }
        [Required]
        public string Land { get; set; }
        [ForeignKey("Customer")]
        [Required]
        public string Email { get; set; }
        

    }
}