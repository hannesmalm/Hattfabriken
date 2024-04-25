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

        public DbSet<Hat> Hats { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<QuantityRequest> QuantityRequests { get; set; }
        public DbSet<Order> Orders { get; set; }





        public DbSet<SpecialEffects> SpecialEffects { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<QuantityRequest>()
                .HasOne(q => q.Material)               // QuantityRequest has one Material
                .WithMany()                            // Material can have many QuantityRequests
                .HasForeignKey(q => q.MaterialName)   // Foreign key property
                .HasPrincipalKey(m => m.MaterialName); // Principal key property
            modelBuilder.Entity<SpecialEffects>()
                .Property(m => m.Price)
                .HasColumnType("decimal(18, 2)");
            // Call the seeding method
            SeedMaterials(modelBuilder);
            SeedOrders(modelBuilder);
            SeedUsers(modelBuilder);
        }

        private void SeedMaterials(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Material>().HasData(
                new Material { MaterialName = "Leather", MaterialQuantity = 1000, MaterialSupplier = "Leather@gmail.com", Price = 45, MaterialHsCode = "4202 91 80 10" },
                new Material { MaterialName = "Straw", MaterialQuantity = 800, MaterialSupplier = "StrawSwag@icloud.com", Price = 14 , MaterialHsCode = "6501 00 10 00" },
                new Material { MaterialName = "Cloth", MaterialQuantity = 2200, MaterialSupplier = "ClothCircus@hotmail.com", Price = 13, MaterialHsCode = "6501 00 10 00" },
                new Material { MaterialName = "Snakeskin", MaterialQuantity = 400, MaterialSupplier = "SnakeKiller@icloud.com", Price = 84, MaterialHsCode = "4202 91 80 10" },
                new Material { MaterialName = "Felt", MaterialQuantity = 600, MaterialSupplier = "FeltFear@icloud.com", Price = 14, MaterialHsCode = "4202 91 80 10" },
                new Material { MaterialName = "Panama", MaterialQuantity = 900, MaterialSupplier = "PanamaSwag@icloud.com", Price = 16, MaterialHsCode = "6501 00 10 00" },
                new Material { MaterialName = "Cotton", MaterialQuantity = 200, MaterialSupplier = "CottonCorner@icloud.com", Price = 16, MaterialHsCode = "6501 00 10 00" },
                new Material { MaterialName = "Linen", MaterialQuantity = 300, MaterialSupplier = "GrischLaidback@icloud.com", Price = 28, MaterialHsCode = "6501 00 10 00" },
                new Material { MaterialName = "Satin", MaterialQuantity = 1000, MaterialSupplier = "SatinSwag@icloud.com", Price = 12, MaterialHsCode = "6501 00 10 00" },
                new Material { MaterialName = "Polyester", MaterialQuantity = 2900, MaterialSupplier = "PolyesterChina@icloud.com", Price = 11, MaterialHsCode = "6501 00 10 00" }

            );
        }

        private void SeedOrders(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    Id = 1,
                    Material = "Leather",
                    Measurement = 58,
                    Height = 10,
                    Commentary = "Beställningen brådskar.",
                    SpecialEffects = "Waterproof",
                    Address = "Köpmansgatan 10",
                    PostalCode = 12345,
                    PhoneNumber = "0701234567",
                    Country = "Sverige",
                    Email = "kund@example.com",
                    Name = "Kund Namnsson",
                    Status = "To-Do",
                    EstimatedDate = new DateTime(2023, 10, 1),
                    Maker = "Otto",
                    Delivery = true
                },
                new Order
                {
                    Id = 2,
                    Material = "Straw",
                    Measurement = 60,
                    Height = 8,
                    Commentary = "Extra storlek behövs.",
                    SpecialEffects = "Sunproof",
                    Address = "Handelsgatan 20",
                    PostalCode = 23456,
                    PhoneNumber = "0707654321",
                    Country = "Sverige",
                    Email = "annan.kund@example.com",
                    Name = "Annan Kundsson",
                    Status = "Judith-Ongoing",
                    EstimatedDate = new DateTime(2023, 11, 15),
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
                    SpecialEffects = "Pärlor",
                    Address = "Blommans väg 3",
                    PostalCode = 34567,
                    PhoneNumber = "0712345678",
                    Country = "Sverige",
                    Email = "sommar@example.com",
                    Name = "Sommar Svensson",
                    Status = "To-Do",
                    EstimatedDate = new DateTime(2024, 6, 1),
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
                    SpecialEffects = "Insulated",
                    Address = "Vintergatan 45",
                    PostalCode = 45678,
                    PhoneNumber = "0723456789",
                    Country = "Sverige",
                    Email = "vinter@example.com",
                    Name = "Vinter Vintersson",
                    Status = "To-Do",
                    EstimatedDate = new DateTime(2024, 1, 10),
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
                    SpecialEffects = "Shiny",
                    Address = "Glamourgatan 12",
                    PostalCode = 56789,
                    PhoneNumber = "0734567890",
                    Country = "Sverige",
                    Email = "gala@example.com",
                    Name = "Gala Galesson",
                    Status = "Completed",
                    EstimatedDate = new DateTime(2024, 3, 20),
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
                    SpecialEffects = "Stiff",
                    Address = "Snabbvägen 30",
                    PostalCode = 67890,
                    PhoneNumber = "0745678901",
                    Country = "Sverige",
                    Email = "snabb@example.com",
                    Name = "Snabb Snabbsson",
                    Status = "To-Do",
                    EstimatedDate = new DateTime(2024, 5, 5),
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
                    SpecialEffects = "Vintage",
                    Address = "Retrogatan 56",
                    PostalCode = 78901,
                    PhoneNumber = "0756789012",
                    Country = "Sverige",
                    Email = "retro@example.com",
                    Name = "Retro Retrosson",
                    Status = "Completed",
                    EstimatedDate = new DateTime(2024, 8, 15),
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
                    SpecialEffects = "Breathable",
                    Address = "Solgatan 78",
                    PostalCode = 89012,
                    PhoneNumber = "0767890123",
                    Country = "Sverige",
                    Email = "solig@example.com",
                    Name = "Solig Solsson",
                    Status = "Completed",
                    EstimatedDate = new DateTime(2024, 7, 1),
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
                    SpecialEffects = "Waterproof",
                    Address = "Fiskevägen 89",
                    PostalCode = 90123,
                    PhoneNumber = "0778901234",
                    Country = "Sverige",
                    Email = "fiskare@example.com",
                    Name = "Fiskare Fiskarsson",
                    Status = "Completed",
                    EstimatedDate = new DateTime(2024, 9, 22),
                    Maker = "Hugo",
                    Delivery = false
                }
            );
        }
        private void SeedUsers(ModelBuilder modelBuilder)
        {
            var userAdmin1 = new User
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "otto@hattfabriken.com",
                NormalizedUserName = "OTTO@HATTFABRIKEN.COM",
                Email = "otto@hattfabriken.com",
                NormalizedEmail = "OTTO@HATTFABRIKEN.COM",
                EmailConfirmed = true
            };

            var userAdmin2 = new User
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "judith@hattfabriken.com",
                NormalizedUserName = "JUDITH@HATTFABRIKEN.COM",
                Email = "judith@hattfabriken.com",
                NormalizedEmail = "JUDITH@HATTFABRIKEN.COM",
                EmailConfirmed = true
            };

            PasswordHasher<IdentityUser> passwordHasher = new PasswordHasher<IdentityUser>();
            userAdmin1.PasswordHash = passwordHasher.HashPassword(userAdmin1, "Hej123!");
            userAdmin2.PasswordHash = passwordHasher.HashPassword(userAdmin2, "Hej123!");

            modelBuilder.Entity<User>().HasData(userAdmin1, userAdmin2);
        }
    }
}

