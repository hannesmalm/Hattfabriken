using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hattfabriken.Migrations
{
    /// <inheritdoc />
    public partial class mm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "09300a50-1893-4a15-9501-3cff548a223b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4beab734-7cfb-48b2-b20b-13ce7d4499e6");

            migrationBuilder.AlterColumn<string>(
                name: "SpecialEffects",
                table: "Hats",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2b6b8470-f906-4e5d-8b1e-ff49786b6e28", 0, "8a53cc1c-f2be-4272-b41e-0c297605465f", "otto@hattfabriken.com", true, false, null, "OTTO@HATTFABRIKEN.COM", "OTTO@HATTFABRIKEN.COM", "AQAAAAIAAYagAAAAEPBXdpiWxCCtcqT6mGHXuWIRvqGTt8Lr6zcEZdp6WRTP7HIn8K9wRpuqHFGmGUuTPw==", null, false, "d6c9985a-c705-473f-94f9-52d6fe66be25", false, "otto@hattfabriken.com" },
                    { "a36abcfe-b62a-4358-8745-5bf2b4b751ec", 0, "2292a838-9325-4117-a472-fd431579ae05", "judith@hattfabriken.com", true, false, null, "JUDITH@HATTFABRIKEN.COM", "JUDITH@HATTFABRIKEN.COM", "AQAAAAIAAYagAAAAEG8K9/V+ESH0Id9DEEjvHSq7NuzElLjIa2+5R7wyrY8n8xxIMNRQ7XIOoPA9CxO8vQ==", null, false, "d62f708a-b9a4-4cff-9b02-685c648c972d", false, "judith@hattfabriken.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b6b8470-f906-4e5d-8b1e-ff49786b6e28");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a36abcfe-b62a-4358-8745-5bf2b4b751ec");

            migrationBuilder.AlterColumn<string>(
                name: "SpecialEffects",
                table: "Hats",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "09300a50-1893-4a15-9501-3cff548a223b", 0, "72da1334-c48a-44dd-b18f-67648fcab67b", "otto@hattfabriken.com", true, false, null, "OTTO@HATTFABRIKEN.COM", "OTTO@HATTFABRIKEN.COM", "AQAAAAIAAYagAAAAEI4KXsn6uFL3L4NSFaMgYunsak9YgvpdfY3KV7dPvxG/Eb0zRzqb+T4MO2gXRZCBHQ==", null, false, "c6970dcb-8585-44ba-ae58-5a37b91d316f", false, "otto@hattfabriken.com" },
                    { "4beab734-7cfb-48b2-b20b-13ce7d4499e6", 0, "d79b0b78-7de2-49a6-b682-15005bc7ddee", "judith@hattfabriken.com", true, false, null, "JUDITH@HATTFABRIKEN.COM", "JUDITH@HATTFABRIKEN.COM", "AQAAAAIAAYagAAAAEC+OyStyXcpn9kbxAagqbBDgHrHTVVsylTysrsGFqgdiHc4k2Ymas+KU2h2LArrpWg==", null, false, "7b6439bb-dc99-4f4f-a17b-dd9b88f047ff", false, "judith@hattfabriken.com" }
                });
        }
    }
}
