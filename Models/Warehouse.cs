using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NuGet.LibraryModel;

namespace Hattfabriken.Models
{
    public class Warehouse
    {
        [Key]
        public int WarehouseId { get; set; }
        [ForeignKey("Material")]
        public string MaterialName { get; set; }
        public int Quanitity {  get; set; }

    }
}
