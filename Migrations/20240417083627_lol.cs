using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hattfabriken.Migrations
{
    /// <inheritdoc />
    public partial class lol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IdentityUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUser", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "IdentityUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "225f0673-4662-4dde-9fa0-546cdd29ff0e", 0, "dff53637-c56d-41a8-8cbc-80e16a476147", "admin2@example.com", true, false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEE3izxQCLZi13hVLRhDCEJfHUeU+/ybxtTcFFcjYXAJaSrJzlLATEeu0C5LD6N/Mog==", null, false, "1099ade5-7fba-46b1-b0c7-965168a2ca18", false, "admin2@example.com" },
                    { "e69bcdb2-cd4a-4901-9c37-0800bd28f70d", 0, "73bcd7f1-179f-4458-ac86-9ea56bfa75bf", "admin1@example.com", true, false, null, "ADMIN1@EXAMPLE.COM", "ADMIN1@EXAMPLE.COM", "AQAAAAIAAYagAAAAENYDfFECTXF4LCj3rMQJ0QqD0T+75xKiqZFHzMoq6kLtRazIZjkU7rs+5vqV0Vsq3w==", null, false, "d2b9e041-681a-479b-b51d-2aa729d7245d", false, "admin1@example.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityUser");
        }
    }
}
