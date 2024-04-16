using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hattfabriken.Migrations
{
    /// <inheritdoc />
    public partial class AddTotalKostnadToOffer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "TotalKostnad",
                table: "Offers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalKostnad",
                table: "Offers");
        }
    }
}
