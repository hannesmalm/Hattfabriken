using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hattfabriken.Migrations
{
    /// <inheritdoc />
    public partial class hej : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Materials",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Cloth",
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Cotton",
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Felt",
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Leather",
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Linen",
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Panama",
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Polyester",
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Satin",
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Snakeskin",
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Straw",
                column: "Type",
                value: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Materials",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
    }
}
