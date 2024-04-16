using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hattfabriken.Migrations
{
    /// <inheritdoc />
    public partial class jrf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Hats",
                table: "Hats");

            migrationBuilder.RenameTable(
                name: "Hats",
                newName: "Hattar");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hattar",
                table: "Hattar",
                column: "HatId");

            migrationBuilder.CreateTable(
                name: "QuantityRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RequestedQuantity = table.Column<int>(type: "int", nullable: false),
                    IsConfirmed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuantityRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuantityRequests_Materials_MaterialName",
                        column: x => x.MaterialName,
                        principalTable: "Materials",
                        principalColumn: "MaterialName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialName", "MaterialQuantity", "MaterialSupplier", "Price" },
                values: new object[,]
                {
                    { "Cloth", 2200, "ClothCircus@hotmail.com", 13 },
                    { "Cotton", 200, "CottonCorner@icloud.com", 16 },
                    { "Felt", 600, "FeltFear@icloud.com", 14 },
                    { "Leather", 1000, "Leather@gmail.com", 45 },
                    { "Linen", 300, "GrischLaidback@icloud.com", 28 },
                    { "Panama", 900, "PanamaSwag@icloud.com", 16 },
                    { "Polyester", 2900, "PolyesterChina@icloud.com", 11 },
                    { "Satin", 1000, "SatinSwag@icloud.com", 12 },
                    { "Snakeskin", 400, "SnakeKiller@icloud.com", 84 },
                    { "Straw", 800, "StrawSwag@icloud.com", 14 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuantityRequests_MaterialName",
                table: "QuantityRequests",
                column: "MaterialName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuantityRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hattar",
                table: "Hattar");

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
                keyValue: "Leather");

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

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Straw");

            migrationBuilder.RenameTable(
                name: "Hattar",
                newName: "Hats");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hats",
                table: "Hats",
                column: "HatId");
        }
    }
}
