using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Hattfabriken.Models;

namespace Hattfabriken.Models.ViewModels
{
    public class RequestViewModel
    {
        public Forfragan Forfragan { get; set; }

        public int ForfraganID { get; set; }

        public int HatId { get; set; }

        [Required(ErrorMessage = "Material måste anges")]
        public string Material { get; set; }

        [Required(ErrorMessage = "Mått måste anges")]
        public int Matt { get; set; }

        [Required(ErrorMessage = "Höjd måste anges")]
        public int Hojd { get; set; }

        public string Kommentar { get; set; }

        public List<string> SelectedSpecialEffekter { get; set; }

        [Required(ErrorMessage = "Adress måste anges")]
        public string Adress { get; set; }

        [Required(ErrorMessage = "Postnummer måste anges")]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "Postnumret måste vara 5 siffror.")]
        public int Postnummer { get; set; }

        [Required(ErrorMessage = "Telefonnummer måste anges")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Telefonnumret får bara innehålla siffror.")]
        public int Telefonnummer { get; set; }

        [Required(ErrorMessage = "Land måste anges")]
        public string Land { get; set; }

        [Required(ErrorMessage = "Email måste anges")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Ange en giltig e-postadress.")]
        public string Email { get; set; }
    }
}
