using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Permissions;

namespace Hattfabriken.Models
{
    public class Request
    {
        [Key]
        public int ForfraganID { get; set; }

        [ForeignKey("Hatt")]
        public int HatId { get; set; }
       
        public string Material { get; set; }
       
        public int Measurement { get; set; }
       
        public int Height { get; set; }

        public string Commentary { get; set; }

        public List<string> SpecialEffects { get; set; }
        
        public string Adress { get; set; }
        
        public int PostalCode { get; set; }
        
        public string PhoneNumber { get; set; }
     
        public string Country { get; set; }

        [ForeignKey("Customer")]
        public string Email { get; set; }

        public string Name { get; set; }

    }
}