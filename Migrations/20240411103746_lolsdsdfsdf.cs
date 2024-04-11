using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hattfabriken.Migrations
{
    /// <inheritdoc />
    public partial class lolsdsdfsdf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsConfirmed",
                table: "Materials",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Cloth",
                column: "IsConfirmed",
                value: false);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Cotton",
                column: "IsConfirmed",
                value: false);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Felt",
                column: "IsConfirmed",
                value: false);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Leather",
                column: "IsConfirmed",
                value: false);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Linen",
                column: "IsConfirmed",
                value: false);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Panama",
                column: "IsConfirmed",
                value: false);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Polyester",
                column: "IsConfirmed",
                value: false);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Satin",
                column: "IsConfirmed",
                value: false);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Snakeskin",
                column: "IsConfirmed",
                value: false);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Straw",
                column: "IsConfirmed",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsConfirmed",
                table: "Materials");
        }
    }
}
