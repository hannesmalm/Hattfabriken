using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Hattfabriken.Models.ViewModels
{
    public class RequestViewModel
    {
        public int? HatId { get; set; }

        public string? Material { get; set; }

        public int? Measurement { get; set; }

        public int? Height { get; set; }

        public int? OuterDimensions { get; set; }

        public string? Commentary { get; set; }

        public List<string>? SelectedSpecialEffekter { get; set; }

        public string Adress { get; set; }

        [RegularExpression(@"^\d{5}$", ErrorMessage = "Postnumret måste vara 5 siffror.")]
        public int PostalCode { get; set; }

        [Required(ErrorMessage = "Telefonnummer måste anges")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Telefonnumret får bara innehålla siffror.")]
        public string PhoneNumber { get; set; }

        public string Country { get; set; }

        [Required(ErrorMessage = "Email måste anges")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Ange en giltig e-postadress.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Namn måste anges")]
        public string Name { get; set; }

        public IFormFile? RequestImage { get; set; }

        // Additional properties to hold the calculated prices
        public int HatTypePrice { get; set; }
        public int MaterialPrice { get; set; }
        public int SpecialEffectsPrice { get; set; }
    }
}
