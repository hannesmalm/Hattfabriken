using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Hattfabriken.Models
{
    public class HatDbContext : IdentityDbContext<User>
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
                new Material { MaterialName = "Leather", MaterialQuantity = 1000, MaterialSupplier = "Leather@gmail.com", Price = 45 },
                new Material { MaterialName = "Straw", MaterialQuantity = 800, MaterialSupplier = "StrawSwag@icloud.com", Price = 14 },
                new Material { MaterialName = "Cloth", MaterialQuantity = 2200, MaterialSupplier = "ClothCircus@hotmail.com", Price = 13 },
                new Material { MaterialName = "Snakeskin", MaterialQuantity = 400, MaterialSupplier = "SnakeKiller@icloud.com", Price = 84 },
                new Material { MaterialName = "Felt", MaterialQuantity = 600, MaterialSupplier = "FeltFear@icloud.com", Price = 14 },
                new Material { MaterialName = "Panama", MaterialQuantity = 900, MaterialSupplier = "PanamaSwag@icloud.com", Price = 16 },
                new Material { MaterialName = "Cotton", MaterialQuantity = 200, MaterialSupplier = "CottonCorner@icloud.com", Price = 16 },
                new Material { MaterialName = "Linen", MaterialQuantity = 300, MaterialSupplier = "GrischLaidback@icloud.com", Price = 28 },
                new Material { MaterialName = "Satin", MaterialQuantity = 1000, MaterialSupplier = "SatinSwag@icloud.com", Price = 12 },
                new Material { MaterialName = "Polyester", MaterialQuantity = 2900, MaterialSupplier = "PolyesterChina@icloud.com", Price = 11 }

            );

            //// Seed admin accounts with hashed passwords
            //PasswordHasher<IdentityUser> passwordHasher = new PasswordHasher<IdentityUser>();

            //Microsoft.EntityFrameworkCore.Metadata.Builders.DataBuilder<IdentityUser> dataBuilder = modelBuilder.Entity<IdentityUser>().HasData(
            //    new IdentityUser
            //    {
            //        Id = Guid.NewGuid().ToString(), // Generate a unique ID
            //        UserName = "admin1@example.com",
            //        NormalizedUserName = "ADMIN1@EXAMPLE.COM",
            //        Email = "admin1@example.com",
            //        NormalizedEmail = "ADMIN1@EXAMPLE.COM",
            //        EmailConfirmed = true,
            //        PasswordHash = passwordHasher.HashPassword(null, "Hej123!") // Hash the password
            //    },
            //    new IdentityUser
            //    {
            //        Id = Guid.NewGuid().ToString(), // Generate a unique ID
            //        UserName = "admin2@example.com",
            //        NormalizedUserName = "ADMIN2@EXAMPLE.COM",
            //        Email = "admin2@example.com",
            //        NormalizedEmail = "ADMIN2@EXAMPLE.COM",
            //        EmailConfirmed = true,
            //        PasswordHash = passwordHasher.HashPassword(null, "Hej123!") // Hash the password
            //    }

            //    );
        }

    }
}
