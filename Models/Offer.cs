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

        public string KundNamn { get; set; }

        public string KundMail { get; set; }

        public string? KundTel { get; set; }

        public double MaterialKostnad { get; set; }

        public double? SpecialeffektKostnad { get; set; }

        public double SpecialtygKostnad { get; set; }

        public double? FraktKostnad { get; set; }

        public DateTime SkapadDatum { get; set; }

        [Required(ErrorMessage = "Choose a date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EstimeratLeveransdatum { get; set; }

    }
}


