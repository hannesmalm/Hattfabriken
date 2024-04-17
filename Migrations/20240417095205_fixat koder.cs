using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hattfabriken.Migrations
{
    /// <inheritdoc />
    public partial class fixatkoder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MaterialHsCode",
                table: "Materials",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Cloth",
                column: "MaterialHsCode",
                value: "6501 00 10 00");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Cotton",
                column: "MaterialHsCode",
                value: "6501 00 10 00");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Felt",
                column: "MaterialHsCode",
                value: "4202 91 80 10");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Leather",
                column: "MaterialHsCode",
                value: "4202 91 80 10");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Linen",
                column: "MaterialHsCode",
                value: "6501 00 10 00");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Panama",
                column: "MaterialHsCode",
                value: "6501 00 10 00");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Polyester",
                column: "MaterialHsCode",
                value: "6501 00 10 00");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Satin",
                column: "MaterialHsCode",
                value: "6501 00 10 00");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Snakeskin",
                column: "MaterialHsCode",
                value: "4202 91 80 10");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Straw",
                column: "MaterialHsCode",
                value: "6501 00 10 00");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaterialHsCode",
                table: "Materials");
        }
    }
}
