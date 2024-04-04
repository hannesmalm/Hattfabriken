using System.ComponentModel.DataAnnotations.Schema;

namespace Hattfabriken.Models
{
    public class Hatt
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        
        // public string Material { get; set; }
    }
}
