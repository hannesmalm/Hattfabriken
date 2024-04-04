using System.ComponentModel.DataAnnotations;

namespace Hattfabriken.Models
{
    public class Customer
    {
        [Key]
        public string Email { get; set; }
        [Required]
        public string CustomerName { get; set; }
        public string Adress { get; set; } 
        public string Country { get; set; }
        public int PhoneNumber { get; set; }



    }
}
