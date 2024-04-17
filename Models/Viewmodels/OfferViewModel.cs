using System;
using System.ComponentModel.DataAnnotations;



namespace Hattfabriken.Models.Viewmodels
{
    public class OfferViewModel
    {
        public string CustomerName { get; set; }

        public string CustomerMail { get; set; }

        public string? CustomerTel { get; set; }

        public double MaterialCost { get; set; }

        public double? SpecialEffectCost { get; set; }

        public double SpecialFabricCost { get; set; }
        
        public double? ShippingCost { get; set; }

        [Required(ErrorMessage = "Choose a date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
       public DateTime EstimatedDeliveryDate { get; set; }

       public double TotalCost { get; set; }

    }
}


