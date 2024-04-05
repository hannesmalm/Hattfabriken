using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hattfabriken.Migrations
{
    /// <inheritdoc />
    public partial class SÄÄÄÄÄD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialName", "MaterialQuantity", "MaterialSupplier", "Price" },
                values: new object[,]
                {
                    { "Leather", 1000, "Supplier A", 10 },
                    { "Straw", 1000, "Supplier B", 8 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Leather");

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Straw");
        }
    }
}
