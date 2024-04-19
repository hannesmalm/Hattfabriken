using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hattfabriken.Migrations
{
    /// <inheritdoc />
    public partial class BigDickMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityUser");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IdentityUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    { "4c15346a-2226-4cbf-abdb-ab57f97f6e1c", 0, "df4bfaac-1254-4fac-ac82-7a76b6f0e870", "admin2@example.com", true, false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHpBS1P4+kahd2B/ovWcwhrew5NhmHiJj+muKSFPwNhNTqmOvzYkeWklrK2RMVq6fw==", null, false, "ef808e1a-925b-4a72-829e-ffcda80dd77a", false, "admin2@example.com" },
                    { "cd40ffd8-83f0-460f-bc95-9b55d1ebd61f", 0, "18e004ef-b839-4cf0-b412-bd62322f900e", "admin1@example.com", true, false, null, "ADMIN1@EXAMPLE.COM", "ADMIN1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDWrrrLfmc80hfVnjmVEPCc0+LKJZoYk49pBRpynpBaU/iPHKHhxmRUtfRRyyFqa1w==", null, false, "e36be372-59ae-4f6f-9084-290c27dc4dfe", false, "admin1@example.com" }
                });
        }
    }
}
