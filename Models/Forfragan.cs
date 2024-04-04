using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Permissions;

namespace Hattfabriken.Models
{
    public class Forfragan
    {
        [Key]
        public int ForfraganID {  get; set; }
        [ForeignKey("Hatt")]
        public int HatId
        { get; set; }
        public string Material { get; set; }
        public int Matt { get; set; }
        public int Hojd { get; set; }
        public string Kommentar { get; set; }
        public string SpecialEffekter { get; set; }
        public string Adress { get; set; }
        public int Postnummer { get; set; }
        public int Telefonnummer { get; set; }
        public string Land { get; set; }
        [ForeignKey("Customer")]
        public string Email { get; set; }
        

    }
}