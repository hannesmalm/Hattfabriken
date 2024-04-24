using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hattfabriken.Migrations
{
    /// <inheritdoc />
    public partial class tilöbaka : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5685be58-91a7-4a2c-88a4-48c5fde7449d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb2de007-c123-4095-a6f9-d934ed7251b5");

            migrationBuilder.RenameColumn(
                name: "SpecialEffects",
                table: "Offers",
                newName: "SpecialEffect");

            migrationBuilder.AddColumn<int>(
                name: "OuterMeasurement",
                table: "Offers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "484eb681-340e-4f0b-bf95-ffdeef75bf68", 0, "8e61c002-4c53-43b9-979a-6c3f6efcddc1", "judith@hattfabriken.com", true, false, null, "JUDITH@HATTFABRIKEN.COM", "JUDITH@HATTFABRIKEN.COM", "AQAAAAIAAYagAAAAEFttx3K4r3gwKesL/mM8EnRepxnwW/pS9aPuPMwGNSsJHzvFOBuJEqkDYzDLn5I7lA==", null, false, "9c60469d-9ebb-4b91-9c33-d289a44592f0", false, "judith@hattfabriken.com" },
                    { "75849edb-6e0f-4698-ab76-0afc0c8a5e48", 0, "481a19f8-7b77-4d7e-8855-bb2c59fab018", "otto@hattfabriken.com", true, false, null, "OTTO@HATTFABRIKEN.COM", "OTTO@HATTFABRIKEN.COM", "AQAAAAIAAYagAAAAEG9xFtdH3eOqQRTRuyqZvRLPX5qx0TlS8iG452nODYmtFmeUVAkNIbEVJ3VatsVmHw==", null, false, "2ba2f1c2-4809-4480-84a8-11113c2a5453", false, "otto@hattfabriken.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "484eb681-340e-4f0b-bf95-ffdeef75bf68");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75849edb-6e0f-4698-ab76-0afc0c8a5e48");

            migrationBuilder.DropColumn(
                name: "OuterMeasurement",
                table: "Offers");

            migrationBuilder.RenameColumn(
                name: "SpecialEffect",
                table: "Offers",
                newName: "SpecialEffects");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5685be58-91a7-4a2c-88a4-48c5fde7449d", 0, "1e5ddee4-d237-47c8-84a4-f6bcd00446f6", "judith@hattfabriken.com", true, false, null, "JUDITH@HATTFABRIKEN.COM", "JUDITH@HATTFABRIKEN.COM", "AQAAAAIAAYagAAAAEGXuiAeohp1RTe75daE04YxXxX1SAuzko23V+1j4VNZvTOENfNw+rBLqTwxC10GLnw==", null, false, "06f40ced-5ea3-4ef6-a173-1debd262c923", false, "judith@hattfabriken.com" },
                    { "bb2de007-c123-4095-a6f9-d934ed7251b5", 0, "262aeaea-104a-423c-a766-6824645c2b9c", "otto@hattfabriken.com", true, false, null, "OTTO@HATTFABRIKEN.COM", "OTTO@HATTFABRIKEN.COM", "AQAAAAIAAYagAAAAEMPVnQ4MB/ivDuZfc+j/dXvM1zbs1TJA4uFBhgqBlfTnqn0i/t0ffJPNeAU4TplKNQ==", null, false, "c602adb3-981d-4efb-9f8f-3ece0748ec31", false, "otto@hattfabriken.com" }
                });
        }
    }
}
