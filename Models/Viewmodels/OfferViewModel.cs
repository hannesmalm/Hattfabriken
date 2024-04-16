using System;
using System.ComponentModel.DataAnnotations;



namespace Hattfabriken.Models.Viewmodels
{
    public class OfferViewModel
    {
        [Required(ErrorMessage = "Customer name is required")]
        public string KundNamn { get; set; }

        [Required(ErrorMessage = "Customer email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string KundMail { get; set; }

        public string? KundTel { get; set; }

        [Required(ErrorMessage = "Material cost is required")]
        public double MaterialKostnad { get; set; }

        public double? SpecialeffektKostnad { get; set; }

        public double? SpecialtygKostnad { get; set; }

        public double? FraktKostnad { get; set; }

        [Required(ErrorMessage = "Estimated date is required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
       public DateTime EstimeratLeveransdatum { get; set; }

        [Required(ErrorMessage = "Total cost is required")]
        public double TotalKostnad { get; set; }

    }
}


