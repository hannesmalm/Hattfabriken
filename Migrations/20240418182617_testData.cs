using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hattfabriken.Migrations
{
    /// <inheritdoc />
    public partial class testData : Migration
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
                    HatType = table.Column<int>(type: "int", nullable: false),
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
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HatId = table.Column<int>(type: "int", nullable: true),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Measurement = table.Column<int>(type: "int", nullable: true),
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
                    MaterialName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    SpecialEffects = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OuterMeasurement = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
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
                table: "Requests",
                columns: new[] { "Adress", "Commentary", "Country", "Date", "DeliveryOrPickup", "Email", "HatId", "Height", "Material", "Measurement", "Name", "PhoneNumber", "PostalCode", "RequestImage", "SpecialEffects", "Status", "Urgent" },
                values: new object[,]
                {
                    { "123 Main Street", "Please make it fancy!", "USA", new DateTime(2024, 4, 20), "Delivery", "john@example.com", 1, 10, "Silk", 20, "John Doe", "123-456-7890", 12345, null, "Feathers", "Pending", true },
                    { "456 Elm Street", "I need it for a wedding", "USA", new DateTime(2024, 4, 21), "Pickup", "jane@example.com", 2, 12, "Wool", 22, "Jane Smith", "987-654-3210", 54321, null, "Ribbons", "Accepted", false },
                    { "789 Oak Street", "Surprise me!", "Canada", new DateTime(2024, 4, 22), "Delivery", "bob@example.com", 3, 8, "Cotton", 18, "Bob Johnson", "555-555-5555", 67890, null, "Bows", "Declined", true },
                    { "321 Pine Street", "I need it for a photoshoot", "UK", new DateTime(2024, 4, 23), "Delivery", "emma@example.com", 4, 9, "Felt", 19, "Emma Watson", "111-222-3333", 23456, null, "None", "Pending", false },
                    { "654 Maple Street", "Please make it elegant", "France", new DateTime(2024, 4, 24), "Pickup", "pierre@example.com", 1, 11, "Straw", 21, "Pierre Leclair", "444-555-6666", 34567, null, "Rhinestones", "Accepted", true },
                    { "987 Cedar Street", "As soon as possible", "Germany", new DateTime(2024, 4, 25), "Delivery", "maria@example.com", 2, 7, "Leather", 17, "Maria Schmidt", "777-888-9999", 45678, null, "Feathers", "Declined", false },
                    { "111 Birch Street", "I want it simple", "Italy", new DateTime(2024, 4, 26), "Delivery", "luca@example.com", 3, 8, "Wool", 16, "Luca Rossi", "123-456-7890", 56789, null, "None", "Pending", false },
                    { "222 Cedar Street", "Make it stand out", "Spain", new DateTime(2024, 4, 27), "Pickup", "sofia@example.com", 3, 10, "Cotton", 20, "Sofia Garcia", "234-567-8901", 67890, null, "Ribbons", "Accepted", true },
                    { "333 Elm Street", "Needs to match my outfit", "Australia", new DateTime(2024, 4, 28), "Delivery", "liam@example.com", 3, 12, "Silk", 22, "Liam Johnson", "345-678-9012", 78901, null, "Bows", "Declined", false },
                    { "444 Oak Street", "Need it for a costume party", "Canada", new DateTime(2024, 4, 29), "Pickup", "olivia@example.com", 1, 9, "Felt", 18, "Olivia Brown", "456-789-0123", 89012, null, "Feathers", "Pending", true },
                    { "555 Pine Street", "Surprise me with the design", "USA", new DateTime(2024, 4, 30), "Delivery", "noah@example.com", 1, 11, "Straw", 20, "Noah Miller", "567-890-1234", 90123, null, "Rhinestones", "Accepted", false },
                    { "666 Maple Street", "I want it to match my shoes", "UK", new DateTime(2024, 5, 1), "Delivery", "oliver@example.com", 2, 7, "Leather", 16, "Oliver Wilson", "678-901-2345", 91234, null, "Bows", "Declined", true },
                    { "777 Elm Street", "Need it for a themed event", "Australia", new DateTime(2024, 5, 2), "Pickup", "ava@example.com", 3, 10, "Silk", 19, "Ava Taylor", "789-012-3456", 92345, null, "Ribbons", "Pending", false },
                    { "888 Cedar Street", "Please make it waterproof", "France", new DateTime(2024, 5, 3), "Delivery", "logan@example.com", 1, 12, "Wool", 21, "Logan White", "890-123-4567", 93456, null, "None", "Accepted", true },
                    { "999 Birch Street", "I want it to match my dress", "Germany", new DateTime(2024, 5, 4), "Delivery", "mia@example.com", 1, 8, "Cotton", 17, "Mia Martinez", "901-234-5678", 94567, null, "Feathers", "Declined", false },
                    { "1010 Pine Street", "I need it for a theater production", "Canada", new DateTime(2024, 5, 5), "Pickup", "jack@example.com", 1, 11, "Felt", 20, "Jack Brown", "912-345-6789", 95678, null, "Rhinestones", "Pending", true },
                    { "1111 Oak Street", "Surprise me with the design", "USA", new DateTime(2024, 5, 6), "Delivery", "sophia@example.com", 1, 9, "Straw", 18, "Sophia Wilson", "923-456-7890", 96789, null, "Bows", "Accepted", false },
                    { "1212 Elm Street", "Needs to match my hat", "UK", new DateTime(2024, 5, 7), "Delivery", "ethan@example.com", 2, 7, "Leather", 16, "Ethan Anderson", "934-567-8901", 97890, null, "None", "Declined", true },
                    { "1313 Cedar Street", "I want it to be eco-friendly", "Australia", new DateTime(2024, 5, 8), "Pickup", "olivia@example.com", 1, 10, "Silk", 19, "Olivia Lee", "945-678-9012", 98901, null, "Feathers", "Pending", false },
                    { "1414 Maple Street", "Please make it reversible", "France", new DateTime(2024, 5, 9), "Delivery", "william@example.com", 3, 12, "Wool", 21, "William Garcia", "956-789-0123", 99012, null, "Ribbons", "Accepted", true },
                    { "1515 Birch Street", "I want it to be adjustable", "Germany", new DateTime(2024, 5, 10), "Delivery", "emily@example.com", 1, 8, "Cotton", 17, "Emily Clark", "967-890-1234", 99123, null, "None", "Declined", false },
                    { "1616 Pine Street", "Needs to be lightweight", "Canada", new DateTime(2024, 5, 11), "Pickup", "noah@example.com", 2, 11, "Felt", 20, "Noah Lewis", "978-901-2345", 99234, null, "Rhinestones", "Pending", true }


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
                name: "QuantityRequests");

            migrationBuilder.DropTable(
                name: "Requests");

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
