using System;



namespace Hattfabriken.Models.Viewmodels
{
    public class OfferViewModel
    {

        public string? KundNamn { get; set; }

        public string? KundMail {  get; set; }

        public int OffertId { get; set; }

        public decimal MaterialKostand {  get; set; }

        public decimal SpecialeffektKostand { get; set; }

        public decimal SpecialtygKostnad {  get; set; }

        public decimal FraktKostnad { get; set; }

        public DateTime EstimeratLeveransdatum { get; set; }


    }
}


