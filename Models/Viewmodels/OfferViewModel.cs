using System;
using System.ComponentModel.DataAnnotations;



namespace Hattfabriken.Models.Viewmodels
{
    public class OfferViewModel
    {

        public string? KundNamn { get; set; }

        public string? KundMail { get; set; }

        public int OffertId { get; set; }

        public decimal MaterialKostnad { get; set; }

        public decimal SpecialeffektKostnad { get; set; }

        public decimal SpecialtygKostnad { get; set; }

        public decimal FraktKostnad { get; set; }


        [Required(ErrorMessage = "Choose a date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
       public DateTime EstimeratLeveransdatum { get; set; }


    }
}


