namespace Hattfabriken.Models.DTOs
{
    public class InvoiceData
    {
        public int InvoiceNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        //public List<InvoiceItem> Items { get; set; }
        public DateTime DueDate { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set;}
        public string CompanyEmail { get; set;}
        public string CompanyPhone { get; set; }
        public string CompanyLogoPath { get; set;}
        public double TotalAmount { get; set; }

        public InvoiceData()
        {
            CompanyName = "The Hat Factory";
            CompanyAddress = "Hattgatan 1";
            CompanyEmail = "OttoHatt";
            CompanyPhone = "010-1234567";
            CompanyLogoPath = "lib\\KG9DESawSZG8K495cQrqwQ.png";
        }
    }
}
