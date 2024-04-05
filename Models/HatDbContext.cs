using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hattfabriken.Models
{
    public class HatDbContext : IdentityDbContext
    {
        public HatDbContext(DbContextOptions<HatDbContext> options) : base(options) { }



        public DbSet <Hatt> Hattar {  get; set; }

        public DbSet<Material> Materials { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Forfragan> Forfragor { get; set; }
        public DbSet<Customer> Customers { get; set; }

        //SÄÄÄÄD method for initializing default materials LOOOOOOL
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Call the seeding method
            SeedMaterials(modelBuilder);
        }

        private void SeedMaterials(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Material>().HasData(
                new Material { MaterialName = "Leather", MaterialQuantity = 1000, MaterialSupplier = "Supplier A", Price = 10 },
                new Material { MaterialName = "Straw", MaterialQuantity = 1000, MaterialSupplier = "Supplier B", Price = 8 }
            );
        }

    }
}
