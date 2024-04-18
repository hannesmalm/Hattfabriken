using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Net;
using System.Net.Mail;

namespace Hattfabriken.Models
{
    public class HatDbContext : IdentityDbContext<User>
    {
        public HatDbContext(DbContextOptions<HatDbContext> options) : base(options) { }



        public DbSet<Hatt> Hattar { get; set; }

        public DbSet<Material> Materials { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<QuantityRequest> QuantityRequests { get; set; }
        public DbSet<Order> Orders { get; set; }








        //SÄÄÄÄD method for initializing default materials LOOOOOOL :3
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<QuantityRequest>()
                .HasOne(q => q.Material)               // QuantityRequest has one Material
                .WithMany()                            // Material can have many QuantityRequests
                .HasForeignKey(q => q.MaterialName)   // Foreign key property
                .HasPrincipalKey(m => m.MaterialName); // Principal key property

            // Call the seeding method
            SeedMaterials(modelBuilder);
            SeedOrders(modelBuilder);
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
        }

        private void SeedOrders(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    Id = 1,
                    OfferId = null, // Ersätt med giltigt värde om det finns
                    HatId = null, // Ersätt med giltigt värde om det finns
                    Material = "Leather",
                    Measurement = 58,
                    Height = 10,
                    Commentary = "Beställningen brådskar.",
                    SpecialEffects = new List<string> { "Waterproof" },
                    Adress = "Köpmansgatan 10",
                    PostalCode = 12345,
                    PhoneNumber = "0701234567",
                    Country = "Sverige",
                    Email = "kund@example.com",
                    Name = "Kund Namnsson",
                    Status = "To-Do",
                    Date = new DateTime(2023, 10, 1),
                    Maker = "Otto",
                    Delivery = true
                },
                new Order
                {
                    Id = 2,
                    OfferId = null, // Ersätt med giltigt värde om det finns
                    HatId = null, // Ersätt med giltigt värde om det finns
                    Material = "Straw",
                    Measurement = 60,
                    Height = 8,
                    Commentary = "Extra storlek behövs.",
                    SpecialEffects = new List<string> { "Sunproof" },
                    Adress = "Handelsgatan 20",
                    PostalCode = 23456,
                    PhoneNumber = "0707654321",
                    Country = "Sverige",
                    Email = "annan.kund@example.com",
                    Name = "Annan Kundsson",
                    Status = "Judith Ongoing",
                    Date = new DateTime(2023, 11, 15),
                    Maker = "Judith",
                    Delivery = false
                },
                new Order
                {
                    Id = 3,
                    Material = "Cotton",
                    Measurement = 57,
                    Height = 9,
                    Commentary = "Behöver för sommarsäsongen.",
                    SpecialEffects = new List<string> { "Lightweight" },
                    Adress = "Blommans väg 3",
                    PostalCode = 34567,
                    PhoneNumber = "0712345678",
                    Country = "Sverige",
                    Email = "sommar@example.com",
                    Name = "Sommar Svensson",
                    Status = "To-Do",
                    Date = new DateTime(2024, 6, 1),
                    Maker = "Greta",
                    Delivery = true
                },
                new Order
                {
                    Id = 4,
                    Material = "Wool",
                    Measurement = 59,
                    Height = 12,
                    Commentary = "Vinterdesign önskas.",
                    SpecialEffects = new List<string> { "Insulated" },
                    Adress = "Vintergatan 45",
                    PostalCode = 45678,
                    PhoneNumber = "0723456789",
                    Country = "Sverige",
                    Email = "vinter@example.com",
                    Name = "Vinter Vintersson",
                    Status = "To-Do",
                    Date = new DateTime(2024, 1, 10),
                    Maker = "Hugo",
                    Delivery = false
                },
                new Order
                {
                    Id = 5,
                    Material = "Silk",
                    Measurement = 56,
                    Height = 7,
                    Commentary = "För speciell gala.",
                    SpecialEffects = new List<string> { "Shiny" },
                    Adress = "Glamourgatan 12",
                    PostalCode = 56789,
                    PhoneNumber = "0734567890",
                    Country = "Sverige",
                    Email = "gala@example.com",
                    Name = "Gala Galesson",
                    Status = "Completed",
                    Date = new DateTime(2024, 3, 20),
                    Maker = "Freja",
                    Delivery = true
                },
                new Order
                {
                    Id = 6,
                    Material = "Felt",
                    Measurement = 55,
                    Height = 10,
                    Commentary = "Snabb leverans krävs.",
                    SpecialEffects = new List<string> { "Stiff" },
                    Adress = "Snabbvägen 30",
                    PostalCode = 67890,
                    PhoneNumber = "0745678901",
                    Country = "Sverige",
                    Email = "snabb@example.com",
                    Name = "Snabb Snabbsson",
                    Status = "To-Do",
                    Date = new DateTime(2024, 5, 5),
                    Maker = "Otto",
                    Delivery = true
                },
                new Order
                {
                    Id = 7,
                    Material = "Leather",
                    Measurement = 61,
                    Height = 11,
                    Commentary = "Retrostil önskas.",
                    SpecialEffects = new List<string> { "Vintage" },
                    Adress = "Retrogatan 56",
                    PostalCode = 78901,
                    PhoneNumber = "0756789012",
                    Country = "Sverige",
                    Email = "retro@example.com",
                    Name = "Retro Retrosson",
                    Status = "Completed",
                    Date = new DateTime(2024, 8, 15),
                    Maker = "Judith",
                    Delivery = false
                },
                new Order
                {
                    Id = 8,
                    Material = "Straw",
                    Measurement = 58,
                    Height = 9,
                    Commentary = "Lätt och luftig för sommarbruk.",
                    SpecialEffects = new List<string> { "Breathable" },
                    Adress = "Solgatan 78",
                    PostalCode = 89012,
                    PhoneNumber = "0767890123",
                    Country = "Sverige",
                    Email = "solig@example.com",
                    Name = "Solig Solsson",
                    Status = "Completed",
                    Date = new DateTime(2024, 7, 1),
                    Maker = "Greta",
                    Delivery = true
                },
                new Order
                {
                    Id = 9,
                    Material = "Polyester",
                    Measurement = 62,
                    Height = 8,
                    Commentary = "Vattenavvisande för fiske.",
                    SpecialEffects = new List<string> { "Waterproof" },
                    Adress = "Fiskevägen 89",
                    PostalCode = 90123,
                    PhoneNumber = "0778901234",
                    Country = "Sverige",
                    Email = "fiskare@example.com",
                    Name = "Fiskare Fiskarsson",
                    Status = "Completed",
                    Date = new DateTime(2024, 9, 22),
                    Maker = "Hugo",
                    Delivery = false
                }
            );
        }

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

