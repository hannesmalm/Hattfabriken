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
            seedSpecialEffects(modelBuilder);
            SeedHats(modelBuilder);
        }

        private void SeedMaterials(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Material>().HasData(
                new Material { MaterialName = "Leather", MaterialQuantity = 1000, MaterialSupplier = "Leather@gmail.com", Price = 4500, MaterialHsCode = "4202 91 80 10" },
                new Material { MaterialName = "Straw", MaterialQuantity = 800, MaterialSupplier = "StrawSwag@icloud.com", Price = 1400, MaterialHsCode = "6501 00 10 00" },
                new Material { MaterialName = "Cloth", MaterialQuantity = 2200, MaterialSupplier = "ClothCircus@hotmail.com", Price = 1300, MaterialHsCode = "6501 00 10 00" },
                new Material { MaterialName = "Snakeskin", MaterialQuantity = 400, MaterialSupplier = "SnakeKiller@icloud.com", Price = 8400, MaterialHsCode = "4202 91 80 10" },
                new Material { MaterialName = "Felt", MaterialQuantity = 600, MaterialSupplier = "FeltFear@icloud.com", Price = 1400, MaterialHsCode = "4202 91 80 10" },
                new Material { MaterialName = "Panama", MaterialQuantity = 900, MaterialSupplier = "PanamaSwag@icloud.com", Price = 1600, MaterialHsCode = "6501 00 10 00" },
                new Material { MaterialName = "Cotton", MaterialQuantity = 200, MaterialSupplier = "CottonCorner@icloud.com", Price = 1600, MaterialHsCode = "6501 00 10 00" },
                new Material { MaterialName = "Linen", MaterialQuantity = 300, MaterialSupplier = "GrischLaidback@icloud.com", Price = 2800, MaterialHsCode = "6501 00 10 00" },
                new Material { MaterialName = "Satin", MaterialQuantity = 1000, MaterialSupplier = "SatinSwag@icloud.com", Price = 1200, MaterialHsCode = "6501 00 10 00" },
                new Material { MaterialName = "Polyester", MaterialQuantity = 2900, MaterialSupplier = "PolyesterChina@icloud.com", Price = 1100, MaterialHsCode = "6501 00 10 00" }

            );
        }

        private void SeedOrders(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    Id = 1,
                    HatType = "Fedora",
                    Material = "Leather",
                    Measurement = 58,
                    Height = 15,
                    Commentary = "Black color, classic style",
                    SpecialEffects = "Feathers",
                    MaterialCost = 5000,
                    SpecialEffectCost = 50,
                    ShippingCost = 200,
                    Address = "123 Elm Street",
                    PostalCode = 10001,
                    PhoneNumber = "123-456-7890",
                    Country = "Sweden",
                    Email = "customer1@example.com",
                    Name = "John Doe",
                    Status = "To-Do",
                    EstimatedDate = DateTime.Today.AddDays(10),
                    Delivery = true,
                    Urgent = false
                },
                new Order
                {
                    Id = 2,
                    HatType = "Trilby",
                    Material = "Straw",
                    Measurement = 57,
                    Height = 12,
                    Commentary = "Lightweight for summer",
                    SpecialEffects = "Lace",
                    MaterialCost = 3000,
                    SpecialEffectCost = 40,
                    ShippingCost = 150,
                    Address = "456 Oak Street",
                    PostalCode = 10002,
                    PhoneNumber = "987-654-3210",
                    Country = "Sweden",
                    Email = "customer2@example.com",
                    Name = "Jane Smith",
                    Status = "To-Do",
                    EstimatedDate = DateTime.Today.AddDays(20),
                    Delivery = true,
                    Urgent = true
                },
                new Order
                {
                    Id = 3,
                    HatType = "Baseball Cap",
                    Material = "Cotton",
                    Measurement = 56,
                    Height = 10,
                    Commentary = "For sports and casual wear",
                    SpecialEffects = "Polished Paper",
                    MaterialCost = 1500,
                    SpecialEffectCost = 20,
                    ShippingCost = 100,
                    Address = "789 Birch Street",
                    PostalCode = 10003,
                    PhoneNumber = "321-456-9870",
                    Country = "Sweden",
                    Email = "customer3@example.com",
                    Name = "Alice Blue",
                    Status = "To-Do",
                    EstimatedDate = DateTime.Today.AddDays(15),
                    Delivery = true,
                    Urgent = false
                },
                new Order
                {
                    Id = 4,
                    HatType = "Beret",
                    Material = "Felt",
                    Measurement = 59,
                    Height = 10,
                    Commentary = "Elegant and stylish",
                    SpecialEffects = "Pearls",
                    MaterialCost = 4500,
                    SpecialEffectCost = 70,
                    ShippingCost = 95,
                    Address = "246 Pine Street",
                    PostalCode = 10004,
                    PhoneNumber = "654-321-4567",
                    Country = "Sweden",
                    Email = "customer4@example.com",
                    Name = "Betty White",
                    Status = "To-Do",
                    EstimatedDate = DateTime.Today.AddDays(25),
                    Delivery = false,
                    Urgent = true
                },
                new Order
                {
                    Id = 5,
                    HatType = "Cloche",
                    Material = "Wool",
                    Measurement = 55,
                    Height = 12,
                    Commentary = "Vintage look",
                    SpecialEffects = "Cloth Flowers",
                    MaterialCost = 4000,
                    SpecialEffectCost = 35,
                    ShippingCost = 85,
                    Address = "135 Maple Street",
                    PostalCode = 10005,
                    PhoneNumber = "852-753-9514",
                    Country = "Sweden",
                    Email = "customer5@example.com",
                    Name = "Carol King",
                    Status = "To-Do",
                    EstimatedDate = DateTime.Today.AddDays(30),
                    Delivery = true,
                    Urgent = false
                },
                new Order
                {
                    Id = 6,
                    HatType = "Panama",
                    Material = "Panama",
                    Measurement = 60,
                    Height = 12,
                    Commentary = "Perfect for the beach",
                    SpecialEffects = "Lace",
                    MaterialCost = 3200,
                    SpecialEffectCost = 40,
                    ShippingCost = 110,
                    Address = "369 Willow Street",
                    PostalCode = 10006,
                    PhoneNumber = "456-789-0123",
                    Country = "Sweden",
                    Email = "customer6@example.com",
                    Name = "Dave Rich",
                    Status = "To-Do",
                    EstimatedDate = DateTime.Today.AddDays(35),
                    Delivery = false,
                    Urgent = true
                },
                new Order
                {
                    Id = 7,
                    HatType = "Bucket Hat",
                    Material = "Linen",
                    Measurement = 58,
                    Height = 10,
                    Commentary = "Casual and comfy",
                    SpecialEffects = "Fake Fur",
                    MaterialCost = 2700,
                    SpecialEffectCost = 90,
                    ShippingCost = 80,
                    Address = "987 Cedar Street",
                    PostalCode = 10007,
                    PhoneNumber = "789-012-3456",
                    Country = "Sweden",
                    Email = "customer7@example.com",
                    Name = "Eva Storm",
                    Status = "To-Do",
                    EstimatedDate = DateTime.Today.AddDays(18),
                    Delivery = true,
                    Urgent = false
                },
                new Order
                {
                    Id = 8,
                    HatType = "Newsboy Cap",
                    Material = "Polyester",
                    Measurement = 57,
                    Height = 13,
                    Commentary = "Retro style",
                    SpecialEffects = "Polished Paper",
                    MaterialCost = 2800,
                    SpecialEffectCost = 20,
                    ShippingCost = 90,
                    Address = "654 Spruce Street",
                    PostalCode = 10008,
                    PhoneNumber = "951-753-8524",
                    Country = "Sweden",
                    Email = "customer8@example.com",
                    Name = "Fred Quest",
                    Status = "To-Do",
                    EstimatedDate = DateTime.Today.AddDays(22),
                    Delivery = false,
                    Urgent = true
                },
                new Order
                {
                    Id = 9,
                    HatType = "Top Hat",
                    Material = "Satin",
                    Measurement = 59,
                    Height = 20,
                    Commentary = "Elegant evening wear",
                    SpecialEffects = "Pearls",
                    MaterialCost = 4900,
                    SpecialEffectCost = 70,
                    ShippingCost = 125,
                    Address = "321 Birch Street",
                    PostalCode = 10009,
                    PhoneNumber = "123-987-6543",
                    Country = "Sweden",
                    Email = "customer9@example.com",
                    Name = "Gina Gold",
                    Status = "To-Do",
                    EstimatedDate = DateTime.Today.AddDays(12),
                    Delivery = true,
                    Urgent = false
                },
                new Order
                {
                    Id = 10,
                    HatType = "Derby",
                    Material = "Cloth",
                    Measurement = 56,
                    Height = 14,
                    Commentary = "Classic derby style",
                    SpecialEffects = "Lurex Thread",
                    MaterialCost = 3500,
                    SpecialEffectCost = 15,
                    ShippingCost = 100,
                    Address = "852 Oak Lane",
                    PostalCode = 10010,
                    PhoneNumber = "321-654-9876",
                    Country = "Sweden",
                    Email = "customer10@example.com",
                    Name = "Harry Hatt",
                    Status = "To-Do",
                    EstimatedDate = DateTime.Today.AddDays(28),
                    Delivery = false,
                    Urgent = true
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
        private void seedSpecialEffects(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SpecialEffects>().HasData(
                new SpecialEffects { SpecialEffectName = "Feathers", Price = 50.00m },
                new SpecialEffects { SpecialEffectName = "Cloth Flowers", Price = 35.00m },
                new SpecialEffects { SpecialEffectName = "Pearls", Price = 70.00m },
                new SpecialEffects { SpecialEffectName = "Lace", Price = 40.00m },
                new SpecialEffects { SpecialEffectName = "Polished Paper", Price = 20.00m },
                new SpecialEffects { SpecialEffectName = "Lurex Thread", Price = 15.00m },
                new SpecialEffects { SpecialEffectName = "Fake Fur", Price = 90.00m }
            );
        }
        private void SeedHats(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hat>().HasData(
                new Hat
                {
                    HatId = 1,
                    HatName = "Classic Fedora",
                    HatType = "Fedora",
                    MaterialName = "Leather",
                    Description = "A timeless choice for any formal occasion.",
                    SpecialEffects = "None",
                    OuterMeasurement = 58,
                    Quantity = 120,
                    MaterialCost = 2000.00,
                    SpecialEffectCost = 0.00
                },
                new Hat
                {
                    HatId = 2,
                    HatName = "Summer Straw Hat",
                    HatType = "Panama",
                    MaterialName = "Straw",
                    Description = "Perfect for a sunny day out in the park or at the beach.",
                    SpecialEffects = "Ribbon",
                    OuterMeasurement = 56,
                    Quantity = 85,
                    MaterialCost = 1500.00,
                    SpecialEffectCost = 50.00
                },
                new Hat
                {
                    HatId = 3,
                    HatName = "Elegant Top Hat",
                    HatType = "Top Hat",
                    MaterialName = "Felt",
                    Description = "Ideal for weddings and formal evening events.",
                    SpecialEffects = "Silk Band",
                    OuterMeasurement = 60,
                    Quantity = 40,
                    MaterialCost = 3000.00,
                    SpecialEffectCost = 100.00
                },
                new Hat
                {
                    HatId = 4,
                    HatName = "Casual Baseball Cap",
                    HatType = "Baseball Cap",
                    MaterialName = "Cotton",
                    Description = "A casual wear staple, perfect for outdoor activities.",
                    SpecialEffects = "Embroidery",
                    OuterMeasurement = 57,
                    Quantity = 200,
                    MaterialCost = 800.00,
                    SpecialEffectCost = 30.00
                },
                new Hat
                {
                    HatId = 5,
                    HatName = "Vintage Cloche",
                    HatType = "Cloche",
                    MaterialName = "Felt",
                    Description = "A touch of the 1920s style to grace any sophisticated look.",
                    SpecialEffects = "Cloth Flower",
                    OuterMeasurement = 55,
                    Quantity = 60,
                    MaterialCost = 2500.00,
                    SpecialEffectCost = 45.00
                }
            );
        }
    }
}

