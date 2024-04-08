using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hattfabriken.Migrations
{
    /// <inheritdoc />
    public partial class users : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IdentityUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_IdentityUser", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "IdentityUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1daf9ab9-76b0-45cf-870f-fbabb496ebaf", 0, "7eb51ab7-ac85-4e55-b0d1-a027f57f0eb6", "admin1@example.com", true, false, null, "ADMIN1@EXAMPLE.COM", "ADMIN1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBa3mRl1LPVkpkD6egF7o9qfobl2zDYWccEjmKPhwly3ry1mCsqVSvH2T0M9yhx/kA==", null, false, "1ecc9f36-d768-4e01-b2d3-b9d1446ffedf", false, "admin1@example.com" },
                    { "30d65e6d-cc63-47f5-a0e3-65b9ff2112b7", 0, "302c966d-bb0c-4a3d-a62e-da8559e4fd3f", "admin2@example.com", true, false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOJDEXCNmE8IssdpA5dQKSQeYXba9bK6+YWhSgiZJ3eNvHFSeys05ufy1D0Mv6aeCg==", null, false, "c5d589cc-5bbf-4b2b-9947-c7d87e7a9bda", false, "admin2@example.com" }
                });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Leather",
                columns: new[] { "MaterialSupplier", "Price" },
                values: new object[] { "Leather@gmail.com", 45 });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Straw",
                columns: new[] { "MaterialQuantity", "MaterialSupplier", "Price" },
                values: new object[] { 800, "StrawSwag@icloud.com", 14 });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialName", "MaterialQuantity", "MaterialSupplier", "Price" },
                values: new object[,]
                {
                    { "Cloth", 2200, "ClothCircus@hotmail.com", 13 },
                    { "Cotton", 200, "CottonCorner@icloud.com", 16 },
                    { "Felt", 600, "FeltFear@icloud.com", 14 },
                    { "Linen", 300, "GrischLaidback@icloud.com", 28 },
                    { "Panama", 900, "PanamaSwag@icloud.com", 16 },
                    { "Polyester", 2900, "PolyesterChina@icloud.com", 11 },
                    { "Satin", 1000, "SatinSwag@icloud.com", 12 },
                    { "Snakeskin", 400, "SnakeKiller@icloud.com", 84 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityUser");

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Cloth");

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Cotton");

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Felt");

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Linen");

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Panama");

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Polyester");

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Satin");

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Snakeskin");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Leather",
                columns: new[] { "MaterialSupplier", "Price" },
                values: new object[] { "Supplier A", 10 });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Straw",
                columns: new[] { "MaterialQuantity", "MaterialSupplier", "Price" },
                values: new object[] { 1000, "Supplier B", 8 });
        }
    }
}
