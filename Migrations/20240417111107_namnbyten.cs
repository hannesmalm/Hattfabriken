using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hattfabriken.Migrations
{
    /// <inheritdoc />
    public partial class namnbyten : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FraktKostnad",
                table: "Offers");

            migrationBuilder.RenameColumn(
                name: "TotalKostnad",
                table: "Offers",
                newName: "TotalCost");

            migrationBuilder.RenameColumn(
                name: "SpecialtygKostnad",
                table: "Offers",
                newName: "SpecialEffectCost");

            migrationBuilder.RenameColumn(
                name: "SpecialeffektKostnad",
                table: "Offers",
                newName: "ShippingCost");

            migrationBuilder.RenameColumn(
                name: "SkapadDatum",
                table: "Offers",
                newName: "EstimatedDeliveryDate");

            migrationBuilder.RenameColumn(
                name: "MaterialKostnad",
                table: "Offers",
                newName: "MaterialCost");

            migrationBuilder.RenameColumn(
                name: "KundTel",
                table: "Offers",
                newName: "SpecialEffects");

            migrationBuilder.RenameColumn(
                name: "KundNamn",
                table: "Offers",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "KundMail",
                table: "Offers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "EstimeratLeveransdatum",
                table: "Offers",
                newName: "DateCreated");

            migrationBuilder.AlterColumn<int>(
                name: "Measurement",
                table: "Requests",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Offers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Offers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DeliveryOrPickup",
                table: "Offers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Offers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "HatType",
                table: "Offers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "HatmakerComment",
                table: "Offers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "Offers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Material",
                table: "Offers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Measurement",
                table: "Offers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Offers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PostalCode",
                table: "Offers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Urgent",
                table: "Offers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "DeliveryOrPickup",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "HatType",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "HatmakerComment",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "Material",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "Measurement",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "Urgent",
                table: "Offers");

            migrationBuilder.RenameColumn(
                name: "TotalCost",
                table: "Offers",
                newName: "TotalKostnad");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Offers",
                newName: "KundNamn");

            migrationBuilder.RenameColumn(
                name: "SpecialEffects",
                table: "Offers",
                newName: "KundTel");

            migrationBuilder.RenameColumn(
                name: "SpecialEffectCost",
                table: "Offers",
                newName: "SpecialtygKostnad");

            migrationBuilder.RenameColumn(
                name: "ShippingCost",
                table: "Offers",
                newName: "SpecialeffektKostnad");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Offers",
                newName: "KundMail");

            migrationBuilder.RenameColumn(
                name: "MaterialCost",
                table: "Offers",
                newName: "MaterialKostnad");

            migrationBuilder.RenameColumn(
                name: "EstimatedDeliveryDate",
                table: "Offers",
                newName: "SkapadDatum");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Offers",
                newName: "EstimeratLeveransdatum");

            migrationBuilder.AlterColumn<int>(
                name: "Measurement",
                table: "Requests",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<double>(
                name: "FraktKostnad",
                table: "Offers",
                type: "float",
                nullable: true);
        }
    }
}
