using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [ForeignKey("Customer")]
        public string Email { get; set; }

    }
}