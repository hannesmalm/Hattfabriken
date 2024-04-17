using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hattfabriken.Migrations
{
    /// <inheritdoc />
    public partial class hey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Materials",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Cloth",
                column: "Type",
                value: null);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Cotton",
                column: "Type",
                value: null);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Felt",
                column: "Type",
                value: null);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Leather",
                column: "Type",
                value: null);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Linen",
                column: "Type",
                value: null);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Panama",
                column: "Type",
                value: null);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Polyester",
                column: "Type",
                value: null);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Satin",
                column: "Type",
                value: null);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Snakeskin",
                column: "Type",
                value: null);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Straw",
                column: "Type",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Materials");
        }
    }
}
