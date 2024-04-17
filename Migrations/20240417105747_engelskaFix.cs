using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hattfabriken.Migrations
{
    /// <inheritdoc />
    public partial class engelskaFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hattar");

            migrationBuilder.DropTable(
                name: "IdentityUser");

            migrationBuilder.RenameColumn(
                name: "TotalKostnad",
                table: "Offers",
                newName: "TotalCost");

            migrationBuilder.RenameColumn(
                name: "SpecialtygKostnad",
                table: "Offers",
                newName: "SpecialFabricCost");

            migrationBuilder.RenameColumn(
                name: "SpecialeffektKostnad",
                table: "Offers",
                newName: "SpecialEffectCost");

            migrationBuilder.RenameColumn(
                name: "SkapadDatum",
                table: "Offers",
                newName: "EstimatedDeliveryDate");

            migrationBuilder.RenameColumn(
                name: "MaterialKostnad",
                table: "Offers",
                newName: "MaterialCost");

            migrationBuilder.RenameColumn(
                name: "KundTel",
                table: "Offers",
                newName: "CustomerTel");

            migrationBuilder.RenameColumn(
                name: "KundNamn",
                table: "Offers",
                newName: "CustomerName");

            migrationBuilder.RenameColumn(
                name: "KundMail",
                table: "Offers",
                newName: "CustomerMail");

            migrationBuilder.RenameColumn(
                name: "FraktKostnad",
                table: "Offers",
                newName: "ShippingCost");

            migrationBuilder.RenameColumn(
                name: "EstimeratLeveransdatum",
                table: "Offers",
                newName: "CreatedDate");

            migrationBuilder.CreateTable(
                name: "Hats",
                columns: table => new
                {
                    HatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HatName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    SpecialEffects = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hats", x => x.HatId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hats");

            migrationBuilder.RenameColumn(
                name: "TotalCost",
                table: "Offers",
                newName: "TotalKostnad");

            migrationBuilder.RenameColumn(
                name: "SpecialFabricCost",
                table: "Offers",
                newName: "SpecialtygKostnad");

            migrationBuilder.RenameColumn(
                name: "SpecialEffectCost",
                table: "Offers",
                newName: "SpecialeffektKostnad");

            migrationBuilder.RenameColumn(
                name: "ShippingCost",
                table: "Offers",
                newName: "FraktKostnad");

            migrationBuilder.RenameColumn(
                name: "MaterialCost",
                table: "Offers",
                newName: "MaterialKostnad");

            migrationBuilder.RenameColumn(
                name: "EstimatedDeliveryDate",
                table: "Offers",
                newName: "SkapadDatum");

            migrationBuilder.RenameColumn(
                name: "CustomerTel",
                table: "Offers",
                newName: "KundTel");

            migrationBuilder.RenameColumn(
                name: "CustomerName",
                table: "Offers",
                newName: "KundNamn");

            migrationBuilder.RenameColumn(
                name: "CustomerMail",
                table: "Offers",
                newName: "KundMail");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Offers",
                newName: "EstimeratLeveransdatum");

            migrationBuilder.CreateTable(
                name: "Hattar",
                columns: table => new
                {
                    HatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HatName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    SpecialEffects = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hattar", x => x.HatId);
                });

            migrationBuilder.CreateTable(
                name: "IdentityUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUser", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "IdentityUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4c15346a-2226-4cbf-abdb-ab57f97f6e1c", 0, "df4bfaac-1254-4fac-ac82-7a76b6f0e870", "admin2@example.com", true, false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHpBS1P4+kahd2B/ovWcwhrew5NhmHiJj+muKSFPwNhNTqmOvzYkeWklrK2RMVq6fw==", null, false, "ef808e1a-925b-4a72-829e-ffcda80dd77a", false, "admin2@example.com" },
                    { "cd40ffd8-83f0-460f-bc95-9b55d1ebd61f", 0, "18e004ef-b839-4cf0-b412-bd62322f900e", "admin1@example.com", true, false, null, "ADMIN1@EXAMPLE.COM", "ADMIN1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDWrrrLfmc80hfVnjmVEPCc0+LKJZoYk49pBRpynpBaU/iPHKHhxmRUtfRRyyFqa1w==", null, false, "e36be372-59ae-4f6f-9084-290c27dc4dfe", false, "admin1@example.com" }
                });
        }
    }
}
