using System.ComponentModel.DataAnnotations.Schema;

namespace Hattfabriken.Models.DTOs
{
	public class ShippingLabelData
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Adress { get; set; }
		public int PostalCode { get; set; }
		public string Country { get; set; }
		public int OrderNumber { get; set; }
		public string CompanyName { get; set; }
		public string CompanyAddress { get; set; }
		public string CompanyCountry { get; set; }

		public string CompanyEmail { get; set; }
		public string CompanyPhone { get; set; }

		//HS-Code = product code = varukod
		public string HsCode { get; set; }
		public ShippingLabelData()
		{
			CompanyName = "The Hat Factory";
			CompanyAddress = "Hattgatan 1";
			CompanyCountry = "Sweden";
			CompanyEmail = "OttoHatt";
			CompanyPhone = "010-1234567";
		}
	}
}