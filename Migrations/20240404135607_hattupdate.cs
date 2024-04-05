using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hattfabriken.Migrations
{
    /// <inheritdoc />
    public partial class hattupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Forfragor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Forfragor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Hojd",
                table: "Forfragor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Kommentar",
                table: "Forfragor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Land",
                table: "Forfragor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Material",
                table: "Forfragor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Matt",
                table: "Forfragor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Postnummer",
                table: "Forfragor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SpecialEffekter",
                table: "Forfragor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Telefonnummer",
                table: "Forfragor",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Forfragor");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Forfragor");

            migrationBuilder.DropColumn(
                name: "Hojd",
                table: "Forfragor");

            migrationBuilder.DropColumn(
                name: "Kommentar",
                table: "Forfragor");

            migrationBuilder.DropColumn(
                name: "Land",
                table: "Forfragor");

            migrationBuilder.DropColumn(
                name: "Material",
                table: "Forfragor");

            migrationBuilder.DropColumn(
                name: "Matt",
                table: "Forfragor");

            migrationBuilder.DropColumn(
                name: "Postnummer",
                table: "Forfragor");

            migrationBuilder.DropColumn(
                name: "SpecialEffekter",
                table: "Forfragor");

            migrationBuilder.DropColumn(
                name: "Telefonnummer",
                table: "Forfragor");
        }
    }
}
