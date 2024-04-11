using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hattfabriken.Migrations
{
    /// <inheritdoc />
    public partial class dsbjhdfdfdf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuantityRequests_Materials_MaterialName1",
                table: "QuantityRequests");

            migrationBuilder.DropIndex(
                name: "IX_QuantityRequests_MaterialName1",
                table: "QuantityRequests");

            migrationBuilder.DropColumn(
                name: "MaterialName1",
                table: "QuantityRequests");

            migrationBuilder.AlterColumn<string>(
                name: "MaterialName",
                table: "QuantityRequests",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_QuantityRequests_MaterialName",
                table: "QuantityRequests",
                column: "MaterialName");

            migrationBuilder.AddForeignKey(
                name: "FK_QuantityRequests_Materials_MaterialName",
                table: "QuantityRequests",
                column: "MaterialName",
                principalTable: "Materials",
                principalColumn: "MaterialName",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuantityRequests_Materials_MaterialName",
                table: "QuantityRequests");

            migrationBuilder.DropIndex(
                name: "IX_QuantityRequests_MaterialName",
                table: "QuantityRequests");

            migrationBuilder.AlterColumn<string>(
                name: "MaterialName",
                table: "QuantityRequests",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "MaterialName1",
                table: "QuantityRequests",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_QuantityRequests_MaterialName1",
                table: "QuantityRequests",
                column: "MaterialName1");

            migrationBuilder.AddForeignKey(
                name: "FK_QuantityRequests_Materials_MaterialName1",
                table: "QuantityRequests",
                column: "MaterialName1",
                principalTable: "Materials",
                principalColumn: "MaterialName");
        }
    }
}
