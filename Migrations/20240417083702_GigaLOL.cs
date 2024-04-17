using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hattfabriken.Migrations
{
    /// <inheritdoc />
    public partial class GigaLOL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "225f0673-4662-4dde-9fa0-546cdd29ff0e");

            migrationBuilder.DeleteData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "e69bcdb2-cd4a-4901-9c37-0800bd28f70d");

            migrationBuilder.InsertData(
                table: "IdentityUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4c15346a-2226-4cbf-abdb-ab57f97f6e1c", 0, "df4bfaac-1254-4fac-ac82-7a76b6f0e870", "admin2@example.com", true, false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHpBS1P4+kahd2B/ovWcwhrew5NhmHiJj+muKSFPwNhNTqmOvzYkeWklrK2RMVq6fw==", null, false, "ef808e1a-925b-4a72-829e-ffcda80dd77a", false, "admin2@example.com" },
                    { "cd40ffd8-83f0-460f-bc95-9b55d1ebd61f", 0, "18e004ef-b839-4cf0-b412-bd62322f900e", "admin1@example.com", true, false, null, "ADMIN1@EXAMPLE.COM", "ADMIN1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDWrrrLfmc80hfVnjmVEPCc0+LKJZoYk49pBRpynpBaU/iPHKHhxmRUtfRRyyFqa1w==", null, false, "e36be372-59ae-4f6f-9084-290c27dc4dfe", false, "admin1@example.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "4c15346a-2226-4cbf-abdb-ab57f97f6e1c");

            migrationBuilder.DeleteData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "cd40ffd8-83f0-460f-bc95-9b55d1ebd61f");

            migrationBuilder.InsertData(
                table: "IdentityUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "225f0673-4662-4dde-9fa0-546cdd29ff0e", 0, "dff53637-c56d-41a8-8cbc-80e16a476147", "admin2@example.com", true, false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEE3izxQCLZi13hVLRhDCEJfHUeU+/ybxtTcFFcjYXAJaSrJzlLATEeu0C5LD6N/Mog==", null, false, "1099ade5-7fba-46b1-b0c7-965168a2ca18", false, "admin2@example.com" },
                    { "e69bcdb2-cd4a-4901-9c37-0800bd28f70d", 0, "73bcd7f1-179f-4458-ac86-9ea56bfa75bf", "admin1@example.com", true, false, null, "ADMIN1@EXAMPLE.COM", "ADMIN1@EXAMPLE.COM", "AQAAAAIAAYagAAAAENYDfFECTXF4LCj3rMQJ0QqD0T+75xKiqZFHzMoq6kLtRazIZjkU7rs+5vqV0Vsq3w==", null, false, "d2b9e041-681a-479b-b51d-2aa729d7245d", false, "admin1@example.com" }
                });
        }
    }
}
