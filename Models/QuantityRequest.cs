using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hattfabriken.Models
{
    public class QuantityRequest
    {
        public int Id { get; set; }
        public string MaterialName { get; set; }
         public int RequestedQuantity { get; set; }
        public bool IsConfirmed { get; set; }

        // Navigation property
        public virtual Material Material { get; set; } // :3
    }


}
