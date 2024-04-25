using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hattfabriken.Migrations
{
    /// <inheritdoc />
    public partial class Inint : Migration
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
                    Price = table.Column<int>(type: "int", nullable: false)
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
                    Height = table.Column<int>(type: "int", nullable: false),
                    HatmakerComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialEffects = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliveryOrPickup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Urgent = table.Column<bool>(type: "bit", nullable: false)
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
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Maker = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Delivery = table.Column<bool>(type: "bit", nullable: false)
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
                    DeliveryOrPickup = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    { "4db3da01-9bc0-45b3-ae29-5faa75b52ffa", 0, "127db13e-aabb-4d3d-9961-6957374fd808", "judith@hattfabriken.com", true, false, null, "JUDITH@HATTFABRIKEN.COM", "JUDITH@HATTFABRIKEN.COM", "AQAAAAIAAYagAAAAEOyF6G1C2uPnEP4nnhRwSSy4b+vyaux4Md7cOUkmqLfY3qgT7nJEnGMR3Gzhzk2FCw==", null, false, "6e3af26f-584b-4284-9d5d-b2c596d51afc", false, "judith@hattfabriken.com" },
                    { "aa238a61-80be-48b1-8eca-c4eade45aa7f", 0, "0ca7cc78-5e3d-4262-a76e-2001ed7e6db1", "otto@hattfabriken.com", true, false, null, "OTTO@HATTFABRIKEN.COM", "OTTO@HATTFABRIKEN.COM", "AQAAAAIAAYagAAAAENL3WLRPfNz1NfPnESbtyXmnbdvo6/+v4rzYP486cQrN7MUs+IUvbPUEz7yrTY+1Lg==", null, false, "3d16f1c9-2f59-4ce8-8ebf-a68fb65e0422", false, "otto@hattfabriken.com" }
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialName", "MaterialQuantity", "MaterialSupplier", "Price" },
                values: new object[,]
                {
                    { "Cloth", 2200, "ClothCircus@hotmail.com", 13 },
                    { "Cotton", 200, "CottonCorner@icloud.com", 16 },
                    { "Felt", 600, "FeltFear@icloud.com", 14 },
                    { "Leather", 1000, "Leather@gmail.com", 45 },
                    { "Linen", 300, "GrischLaidback@icloud.com", 28 },
                    { "Panama", 900, "PanamaSwag@icloud.com", 16 },
                    { "Polyester", 2900, "PolyesterChina@icloud.com", 11 },
                    { "Satin", 1000, "SatinSwag@icloud.com", 12 },
                    { "Snakeskin", 400, "SnakeKiller@icloud.com", 84 },
                    { "Straw", 800, "StrawSwag@icloud.com", 14 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "Commentary", "Country", "Date", "Delivery", "Email", "HatImage", "HatType", "Height", "Maker", "Material", "MaterialCost", "Measurement", "Name", "PhoneNumber", "PostalCode", "ShippingCost", "SpecialEffectCost", "SpecialEffects", "Status" },
                values: new object[,]
                {
                    { 1, "Köpmansgatan 10", "Beställningen brådskar.", "Sverige", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "kund@example.com", null, null, 10, "Otto", "Leather", 0.0, 58, "Kund Namnsson", "0701234567", 12345, null, null, "Waterproof", "To-Do" },
                    { 2, "Handelsgatan 20", "Extra storlek behövs.", "Sverige", new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "annan.kund@example.com", null, null, 8, "Judith", "Straw", 0.0, 60, "Annan Kundsson", "0707654321", 23456, null, null, "Sunproof", "Judith-Ongoing" },
                    { 3, "Blommans väg 3", "Behöver för sommarsäsongen.", "Sverige", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "sommar@example.com", null, null, 9, "Greta", "Cotton", 0.0, 57, "Sommar Svensson", "0712345678", 34567, null, null, "Pärlor", "To-Do" },
                    { 4, "Vintergatan 45", "Vinterdesign önskas.", "Sverige", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "vinter@example.com", null, null, 12, "Hugo", "Wool", 0.0, 59, "Vinter Vintersson", "0723456789", 45678, null, null, "Insulated", "To-Do" },
                    { 5, "Glamourgatan 12", "För speciell gala.", "Sverige", new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "gala@example.com", null, null, 7, "Freja", "Silk", 0.0, 56, "Gala Galesson", "0734567890", 56789, null, null, "Shiny", "Completed" },
                    { 6, "Snabbvägen 30", "Snabb leverans krävs.", "Sverige", new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "snabb@example.com", null, null, 10, "Otto", "Felt", 0.0, 55, "Snabb Snabbsson", "0745678901", 67890, null, null, "Stiff", "To-Do" },
                    { 7, "Retrogatan 56", "Retrostil önskas.", "Sverige", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "retro@example.com", null, null, 11, "Judith", "Leather", 0.0, 61, "Retro Retrosson", "0756789012", 78901, null, null, "Vintage", "Completed" },
                    { 8, "Solgatan 78", "Lätt och luftig för sommarbruk.", "Sverige", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "solig@example.com", null, null, 9, "Greta", "Straw", 0.0, 58, "Solig Solsson", "0767890123", 89012, null, null, "Breathable", "Completed" },
                    { 9, "Fiskevägen 89", "Vattenavvisande för fiske.", "Sverige", new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "fiskare@example.com", null, null, 8, "Hugo", "Polyester", 0.0, 62, "Fiskare Fiskarsson", "0778901234", 90123, null, null, "Waterproof", "Completed" }
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
