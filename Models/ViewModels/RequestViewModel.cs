using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Hattfabriken.Models;

namespace Hattfabriken.Models.ViewModels
{
    public class RequestViewModel
    {
        public int HatId { get; set; }

        [Required(ErrorMessage = "Material måste anges")]
        public string Material { get; set; }

        [Required(ErrorMessage = "Mått måste anges")]
        public int Measurement { get; set; }

        [Required(ErrorMessage = "Höjd måste anges")]
        public int Height { get; set; }

        public string Commentary { get; set; }

        public List<string> SelectedSpecialEffekter { get; set; }

        [Required(ErrorMessage = "Adress måste anges")]
        public string Adress { get; set; }

        [Required(ErrorMessage = "Postnummer måste anges")]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "Postnumret måste vara 5 siffror.")]
        public int PostalCode { get; set; }

        [Required(ErrorMessage = "Telefonnummer måste anges")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Telefonnumret får bara innehålla siffror.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Land måste anges")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Email måste anges")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Ange en giltig e-postadress.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Namn måste anges")]
        public string Name { get; set; }
    }
}
