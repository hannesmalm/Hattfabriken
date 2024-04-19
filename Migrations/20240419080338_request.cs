using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hattfabriken.Migrations
{
    /// <inheritdoc />
    public partial class request : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaterialQuantity",
                table: "SpecialEffects");

            migrationBuilder.DropColumn(
                name: "MaterialSupplier",
                table: "SpecialEffects");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Requests");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaterialQuantity",
                table: "SpecialEffects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MaterialSupplier",
                table: "SpecialEffects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
