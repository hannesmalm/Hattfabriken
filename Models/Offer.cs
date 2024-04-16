using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Permissions;

namespace Hattfabriken.Models
{
    public class Offer
    {
        [Key]
        public int OffertId { get; set; }

        public required string KundNamn { get; set; }

        public required string KundMail { get; set; }

        public string? KundTel { get; set; }

        public required double MaterialKostnad { get; set; }

        public double? SpecialeffektKostnad { get; set; }

        public double? SpecialtygKostnad { get; set; }

        public double? FraktKostnad { get; set; }

        public required DateTime SkapadDatum { get; set; }

        [Required(ErrorMessage = "Choose a date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public required DateTime EstimeratLeveransdatum { get; set; }

        public required double TotalKostnad { get; set; }

        //public int MaterialId { get; set; }

    }
}


