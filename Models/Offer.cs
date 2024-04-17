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

        public string CustomerName { get; set; }

        public string CustomerMail { get; set; }

        public string? CustomerTel { get; set; }

        public double MaterialCost { get; set; }

        public double? SpecialEffectCost { get; set; }

        public double SpecialFabricCost { get; set; }

        public double? ShippingCost { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required(ErrorMessage = "Choose a date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EstimatedDeliveryDate { get; set; }

        public double TotalCost { get; set; }

    }
}


