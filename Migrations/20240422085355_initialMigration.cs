using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hattfabriken.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "HatType",
                table: "Offers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "09300a50-1893-4a15-9501-3cff548a223b", 0, "72da1334-c48a-44dd-b18f-67648fcab67b", "otto@hattfabriken.com", true, false, null, "OTTO@HATTFABRIKEN.COM", "OTTO@HATTFABRIKEN.COM", "AQAAAAIAAYagAAAAEI4KXsn6uFL3L4NSFaMgYunsak9YgvpdfY3KV7dPvxG/Eb0zRzqb+T4MO2gXRZCBHQ==", null, false, "c6970dcb-8585-44ba-ae58-5a37b91d316f", false, "otto@hattfabriken.com" },
                    { "4beab734-7cfb-48b2-b20b-13ce7d4499e6", 0, "d79b0b78-7de2-49a6-b682-15005bc7ddee", "judith@hattfabriken.com", true, false, null, "JUDITH@HATTFABRIKEN.COM", "JUDITH@HATTFABRIKEN.COM", "AQAAAAIAAYagAAAAEC+OyStyXcpn9kbxAagqbBDgHrHTVVsylTysrsGFqgdiHc4k2Ymas+KU2h2LArrpWg==", null, false, "7b6439bb-dc99-4f4f-a17b-dd9b88f047ff", false, "judith@hattfabriken.com" }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: "Judith-Ongoing");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "09300a50-1893-4a15-9501-3cff548a223b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4beab734-7cfb-48b2-b20b-13ce7d4499e6");

            migrationBuilder.AlterColumn<int>(
                name: "HatType",
                table: "Offers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: "Judith Ongoing");
        }
    }
}
