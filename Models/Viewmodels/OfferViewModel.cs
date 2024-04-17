using System;
using System.ComponentModel.DataAnnotations;



namespace Hattfabriken.Models.Viewmodels
{
    public class OfferViewModel
    {
        public string KundNamn { get; set; }

        public string KundMail { get; set; }

        public string? KundTel { get; set; }

        public double MaterialKostnad { get; set; }

        public double? SpecialeffektKostnad { get; set; }

        public double SpecialtygKostnad { get; set; }

        public double? FraktKostnad { get; set; }

        [Required(ErrorMessage = "Choose a date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
       public DateTime EstimeratLeveransdatum { get; set; }

       public double TotalKostnad { get; set; }

    }
}


