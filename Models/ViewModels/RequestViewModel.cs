using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Hattfabriken.Models;

namespace Hattfabriken.Models.ViewModels
{
    public class RequestViewModel
    {
        public string? HatType { get; set; }

        public string? Material { get; set; }

        public int? Measurement { get; set; }

        public int? Height { get; set; }

        public int? OuterMeasurement { get; set; }

        public string? Commentary { get; set; }

        public string? SpecialEffects { get; set; }

        public string Adress { get; set; }

        [RegularExpression(@"^\d{5}$", ErrorMessage = "The postal code must be 5 digits.")]
        public int PostalCode { get; set; }

        [Required(ErrorMessage = "The phone number must be provided")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "The phone number must only contain digits.")]
        public string PhoneNumber { get; set; }

        public string Country { get; set; }

        [Required(ErrorMessage = "Email must be provided")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Please provide a valid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please provide a name for your request")]
        public string Name { get; set; }

        public IFormFile? RequestImage { get; set; }

        public bool Delivery { get; set; } 

        public Boolean Urgent { get; set; } 
    }
}