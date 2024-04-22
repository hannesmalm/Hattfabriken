namespace Hattfabriken.Models.DTOs
{
    public class InvoiceData
    {
        public int? InvoiceNumber { get; set; } //Implement when invoice controller is avaliable
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public int CustomerPostalCode { get; set; }
        public string CustomerCountry { get; set; }
        public int OrderNumber { get; set; }
        public DateTime DueDate { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set;}
        public string CompanyEmail { get; set;}
        public string CompanyPhone { get; set; }
        public string CompanyLogoPath { get; set;}
        public string CompanyCountry { get; set; }
        public double TotalAmount { get; set; }
        public double MaterialCost { get; set; }
        public double? SpecialEffectCost { get; set; }
        public double? ShippingCost { get; set; }
        public InvoiceData()
        {
            CompanyName = "The Hat Factory";
            CompanyAddress = "Hattgatan 1";
            CompanyCountry = "Sweden";
            CompanyEmail = "Otto@hattfabriken.com";
            CompanyPhone = "010-1234567";
            CompanyLogoPath = "lib\\KG9DESawSZG8K495cQrqwQ.png";
            DueDate = DateTime.Today.AddDays(30);
            TotalAmount = MaterialCost + (SpecialEffectCost ?? 0) + (ShippingCost ?? 0);
        }
    }
}
