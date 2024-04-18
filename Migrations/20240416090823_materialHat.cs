using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hattfabriken.Migrations
{
    /// <inheritdoc />
    public partial class materialHat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MaterialName",
                table: "Hattar",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Hattar_MaterialName",
                table: "Hattar",
                column: "MaterialName");

            migrationBuilder.AddForeignKey(
                name: "FK_Hattar_Materials_MaterialName",
                table: "Hattar",
                column: "MaterialName",
                principalTable: "Materials",
                principalColumn: "MaterialName",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hattar_Materials_MaterialName",
                table: "Hattar");

            migrationBuilder.DropIndex(
                name: "IX_Hattar_MaterialName",
                table: "Hattar");

            migrationBuilder.AlterColumn<string>(
                name: "MaterialName",
                table: "Hattar",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
