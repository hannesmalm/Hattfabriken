using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hattfabriken.Migrations
{
    /// <inheritdoc />
    public partial class dskjdshlidbud : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuantityRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestedQuantity = table.Column<int>(type: "int", nullable: false),
                    IsConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    MaterialName1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuantityRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuantityRequests_Materials_MaterialName1",
                        column: x => x.MaterialName1,
                        principalTable: "Materials",
                        principalColumn: "MaterialName");
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuantityRequests_MaterialName1",
                table: "QuantityRequests",
                column: "MaterialName1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuantityRequests");
        }
    }
}
