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
    }
}