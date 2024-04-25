using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hattfabriken.Migrations
{
    /// <inheritdoc />
    public partial class hej : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06258c71-bd52-4896-990a-809318bad4d8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "845c9a45-6c72-4706-8458-6bdf597840e8");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "460f0cba-c4b4-45c4-9278-e0f89f459c4c", 0, "a661a64d-990b-42d1-87c5-0dcb44aa5486", "otto@hattfabriken.com", true, false, null, "OTTO@HATTFABRIKEN.COM", "OTTO@HATTFABRIKEN.COM", "AQAAAAIAAYagAAAAEOf05ps90SvneccdKopgzE3iXlFBhPVGBJKlRWbgVxiQ58umpt8Ml7nrkfwog2z/yA==", null, false, "e9d5bc0a-a906-41b0-80bf-3611b12a966d", false, "otto@hattfabriken.com" },
                    { "492ec57f-9f87-482a-9919-ea02f94e3a1c", 0, "77da78d9-8537-448d-8eca-0219231d54a3", "judith@hattfabriken.com", true, false, null, "JUDITH@HATTFABRIKEN.COM", "JUDITH@HATTFABRIKEN.COM", "AQAAAAIAAYagAAAAELAD3QL8+GrqrLSpqe/MwhIc8HF517sLuKOGGTem1QiZlaTQF1igWyHqBp4fqPBcPw==", null, false, "6e3e86ff-a195-4049-9b4f-d7fdb69de256", false, "judith@hattfabriken.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "460f0cba-c4b4-45c4-9278-e0f89f459c4c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "492ec57f-9f87-482a-9919-ea02f94e3a1c");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "06258c71-bd52-4896-990a-809318bad4d8", 0, "8ad352c5-33e9-42a0-ac0d-db14f4436daf", "judith@hattfabriken.com", true, false, null, "JUDITH@HATTFABRIKEN.COM", "JUDITH@HATTFABRIKEN.COM", "AQAAAAIAAYagAAAAEO3sxr15EMiyWVNtvVj1v3+0GnMqIeh367myxGk7ThsT1bpo8EJYIpbWx3wVv1L6Bw==", null, false, "52e69dd8-f2ad-40aa-97ea-9bcbf07db7c4", false, "judith@hattfabriken.com" },
                    { "845c9a45-6c72-4706-8458-6bdf597840e8", 0, "abf5ee49-a7ad-4dc5-884f-b1cc122e5b98", "otto@hattfabriken.com", true, false, null, "OTTO@HATTFABRIKEN.COM", "OTTO@HATTFABRIKEN.COM", "AQAAAAIAAYagAAAAEITS6qLV9vG70ee5KAfCHL/KKdR2M2t9wEcWKzkprY51sVo96JQXLZr+kaRSVAZgDA==", null, false, "4d133721-b530-44b5-adea-b03a34e27406", false, "otto@hattfabriken.com" }
                });
        }
    }
}
