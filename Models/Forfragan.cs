using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Permissions;

namespace Hattfabriken.Models
{
    public class Forfragan
    {
        [Key]
        public int ForfraganID { get; set; }

        [ForeignKey("Hatt")]
        public int HatId { get; set; }

        [Required(ErrorMessage = "Material måste anges")]
        public string Material { get; set; }

        [Required(ErrorMessage = "Matt måste anges")]
        public int Matt { get; set; }

        [Required(ErrorMessage = "Höjd måste anges")]
        public int Hojd { get; set; }

        // Kommentar är inte längre obligatorisk
        public string Kommentar { get; set; }

        public string SpecialEffekter { get; set; }

        [Required(ErrorMessage = "Adress måste anges")]
        public string Adress { get; set; }

        [Required(ErrorMessage = "Postnummer måste anges")]
        public int Postnummer { get; set; }

        [Required(ErrorMessage = "Telefonnummer måste anges")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Telefonnumret får bara innehålla siffror.")]
        public int Telefonnummer { get; set; }

        [Required(ErrorMessage = "Land måste anges")]
        public string Land { get; set; }

        [ForeignKey("Customer")]
        [Required(ErrorMessage = "Email måste anges")]
        public string Email { get; set; }

    }
}