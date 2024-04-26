using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hattfabriken.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    MaterialName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaterialQuantity = table.Column<int>(type: "int", nullable: false),
                    MaterialSupplier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    MaterialHsCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.MaterialName);
                });

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    OffertId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HatType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialCost = table.Column<double>(type: "float", nullable: false),
                    SpecialEffectCost = table.Column<double>(type: "float", nullable: true),
                    ShippingCost = table.Column<double>(type: "float", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstimatedDeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalCost = table.Column<double>(type: "float", nullable: false),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Measurement = table.Column<int>(type: "int", nullable: false),
                    OuterMeasurement = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    HatmakerComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialEffect = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Delivery = table.Column<bool>(type: "bit", nullable: false),
                    Urgent = table.Column<bool>(type: "bit", nullable: false),
                    HatImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.OffertId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HatType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Measurement = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<int>(type: "int", nullable: true),
                    Commentary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialEffects = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HatImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    MaterialCost = table.Column<double>(type: "float", nullable: false),
                    SpecialEffectCost = table.Column<double>(type: "float", nullable: true),
                    ShippingCost = table.Column<double>(type: "float", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstimatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Maker = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Delivery = table.Column<bool>(type: "bit", nullable: false),
                    Urgent = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HatType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Measurement = table.Column<int>(type: "int", nullable: true),
                    OuterMeasurement = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<int>(type: "int", nullable: true),
                    Commentary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialEffects = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Delivery = table.Column<bool>(type: "bit", nullable: false),
                    Urgent = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpecialEffects",
                columns: table => new
                {
                    SpecialEffectName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialEffects", x => x.SpecialEffectName);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    WarehouseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quanitity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.WarehouseId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hats",
                columns: table => new
                {
                    HatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HatName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HatType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecialEffects = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OuterMeasurement = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    HatImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    MaterialCost = table.Column<double>(type: "float", nullable: false),
                    SpecialEffectCost = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hats", x => x.HatId);
                    table.ForeignKey(
                        name: "FK_Hats_Materials_MaterialName",
                        column: x => x.MaterialName,
                        principalTable: "Materials",
                        principalColumn: "MaterialName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuantityRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RequestedQuantity = table.Column<int>(type: "int", nullable: false),
                    IsConfirmed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuantityRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuantityRequests_Materials_MaterialName",
                        column: x => x.MaterialName,
                        principalTable: "Materials",
                        principalColumn: "MaterialName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0cea29c7-18ca-463c-84ce-5bd164b92c68", 0, "56098d55-d845-406a-82f0-169389a7345c", "judith@hattfabriken.com", true, false, null, "JUDITH@HATTFABRIKEN.COM", "JUDITH@HATTFABRIKEN.COM", "AQAAAAIAAYagAAAAEDCRB0kz9Taw60aZ/yuTyMJXpZiQi12iK0b9qcIwzAHqNn6pdsCjbV4ntCD5/aWEJg==", null, false, "1718c84c-4618-4160-a003-980e7122126d", false, "judith@hattfabriken.com" },
                    { "6f66dd5c-e4fe-4323-93a1-d9c8506da2a6", 0, "4925e6eb-c66f-4e54-8912-f842cec70cec", "otto@hattfabriken.com", true, false, null, "OTTO@HATTFABRIKEN.COM", "OTTO@HATTFABRIKEN.COM", "AQAAAAIAAYagAAAAEOKpvkjxnHGnq7CfIKayI/w/2Hnk+uTnXt3AP+zI4JUgrN474gwzXBBzzMWOOczqkg==", null, false, "b2fc2fe9-315d-45aa-bde4-24829507303a", false, "otto@hattfabriken.com" }
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialName", "MaterialHsCode", "MaterialQuantity", "MaterialSupplier", "Price" },
                values: new object[,]
                {
                    { "Cloth", "6501 00 10 00", 2200, "ClothCircus@hotmail.com", 1300 },
                    { "Cotton", "6501 00 10 00", 200, "CottonCorner@icloud.com", 1600 },
                    { "Felt", "4202 91 80 10", 600, "FeltFear@icloud.com", 1400 },
                    { "Leather", "4202 91 80 10", 1000, "Leather@gmail.com", 4500 },
                    { "Linen", "6501 00 10 00", 300, "GrischLaidback@icloud.com", 2800 },
                    { "Panama", "6501 00 10 00", 900, "PanamaSwag@icloud.com", 1600 },
                    { "Polyester", "6501 00 10 00", 2900, "PolyesterChina@icloud.com", 1100 },
                    { "Satin", "6501 00 10 00", 1000, "SatinSwag@icloud.com", 1200 },
                    { "Snakeskin", "4202 91 80 10", 400, "SnakeKiller@icloud.com", 8400 },
                    { "Straw", "6501 00 10 00", 800, "StrawSwag@icloud.com", 1400 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "Commentary", "Country", "Delivery", "Email", "EstimatedDate", "HatImage", "HatType", "Height", "Maker", "Material", "MaterialCost", "Measurement", "Name", "PhoneNumber", "PostalCode", "ShippingCost", "SpecialEffectCost", "SpecialEffects", "Status", "Urgent" },
                values: new object[,]
                {
                    { 1, "123 Elm Street", "Black color, classic style", "Sweden", true, "customer1@example.com", new DateTime(2024, 5, 6, 0, 0, 0, 0, DateTimeKind.Local), null, "Fedora", 15, null, "Leather", 5000.0, 58, "John Doe", "123-456-7890", 10001, 200.0, 50.0, "Feathers", "To-Do", false },
                    { 2, "456 Oak Street", "Lightweight for summer", "Sweden", true, "customer2@example.com", new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), null, "Trilby", 12, null, "Straw", 3000.0, 57, "Jane Smith", "987-654-3210", 10002, 150.0, 40.0, "Lace", "To-Do", true },
                    { 3, "789 Birch Street", "For sports and casual wear", "Sweden", true, "customer3@example.com", new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Local), null, "Baseball Cap", 10, null, "Cotton", 1500.0, 56, "Alice Blue", "321-456-9870", 10003, 100.0, 20.0, "Polished Paper", "To-Do", false },
                    { 4, "246 Pine Street", "Elegant and stylish", "Sweden", false, "customer4@example.com", new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), null, "Beret", 10, null, "Felt", 4500.0, 59, "Betty White", "654-321-4567", 10004, 95.0, 70.0, "Pearls", "To-Do", true },
                    { 5, "135 Maple Street", "Vintage look", "Sweden", true, "customer5@example.com", new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Local), null, "Cloche", 12, null, "Wool", 4000.0, 55, "Carol King", "852-753-9514", 10005, 85.0, 35.0, "Cloth Flowers", "To-Do", false },
                    { 6, "369 Willow Street", "Perfect for the beach", "Sweden", false, "customer6@example.com", new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Local), null, "Panama", 12, null, "Panama", 3200.0, 60, "Dave Rich", "456-789-0123", 10006, 110.0, 40.0, "Lace", "To-Do", true },
                    { 7, "987 Cedar Street", "Casual and comfy", "Sweden", true, "customer7@example.com", new DateTime(2024, 5, 14, 0, 0, 0, 0, DateTimeKind.Local), null, "Bucket Hat", 10, null, "Linen", 2700.0, 58, "Eva Storm", "789-012-3456", 10007, 80.0, 90.0, "Fake Fur", "To-Do", false },
                    { 8, "654 Spruce Street", "Retro style", "Sweden", false, "customer8@example.com", new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Local), null, "Newsboy Cap", 13, null, "Polyester", 2800.0, 57, "Fred Quest", "951-753-8524", 10008, 90.0, 20.0, "Polished Paper", "To-Do", true },
                    { 9, "321 Birch Street", "Elegant evening wear", "Sweden", true, "customer9@example.com", new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), null, "Top Hat", 20, null, "Satin", 4900.0, 59, "Gina Gold", "123-987-6543", 10009, 125.0, 70.0, "Pearls", "To-Do", false },
                    { 10, "852 Oak Lane", "Classic derby style", "Sweden", false, "customer10@example.com", new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), null, "Derby", 14, null, "Cloth", 3500.0, 56, "Harry Hatt", "321-654-9876", 10010, 100.0, 15.0, "Lurex Thread", "To-Do", true }
                });

            migrationBuilder.InsertData(
                table: "SpecialEffects",
                columns: new[] { "SpecialEffectName", "Price" },
                values: new object[,]
                {
                    { "Cloth Flowers", 35.00m },
                    { "Fake Fur", 90.00m },
                    { "Feathers", 50.00m },
                    { "Lace", 40.00m },
                    { "Lurex Thread", 15.00m },
                    { "Pearls", 70.00m },
                    { "Polished Paper", 20.00m }
                });

            migrationBuilder.InsertData(
                table: "Hats",
                columns: new[] { "HatId", "Description", "HatImage", "HatName", "HatType", "MaterialCost", "MaterialName", "OuterMeasurement", "Quantity", "SpecialEffectCost", "SpecialEffects" },
                values: new object[,]
                {
                    { 1, "A timeless choice for any formal occasion.", null, "Classic Fedora", "Fedora", 2000.0, "Leather", 58, 120, 0.0, "None" },
                    { 2, "Perfect for a sunny day out in the park or at the beach.", null, "Summer Straw Hat", "Panama", 1500.0, "Straw", 56, 85, 50.0, "Ribbon" },
                    { 3, "Ideal for weddings and formal evening events.", null, "Elegant Top Hat", "Top Hat", 3000.0, "Felt", 60, 40, 100.0, "Silk Band" },
                    { 4, "A casual wear staple, perfect for outdoor activities.", null, "Casual Baseball Cap", "Baseball Cap", 800.0, "Cotton", 57, 200, 30.0, "Embroidery" },
                    { 5, "A touch of the 1920s style to grace any sophisticated look.", null, "Vintage Cloche", "Cloche", 2500.0, "Felt", 55, 60, 45.0, "Cloth Flower" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Hats_MaterialName",
                table: "Hats",
                column: "MaterialName");

            migrationBuilder.CreateIndex(
                name: "IX_QuantityRequests_MaterialName",
                table: "QuantityRequests",
                column: "MaterialName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Hats");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "QuantityRequests");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "SpecialEffects");

            migrationBuilder.DropTable(
                name: "Warehouses");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Materials");
        }
    }
}
