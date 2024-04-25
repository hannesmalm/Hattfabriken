using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hattfabriken.Migrations
{
    /// <inheritdoc />
    public partial class PostMerge : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "460f0cba-c4b4-45c4-9278-e0f89f459c4c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "492ec57f-9f87-482a-9919-ea02f94e3a1c");

            migrationBuilder.DropColumn(
                name: "DeliveryOrPickup",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "DeliveryOrPickup",
                table: "Offers");

            migrationBuilder.AddColumn<bool>(
                name: "Delivery",
                table: "Requests",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Maker",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "Delivery",
                table: "Offers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<byte[]>(
                name: "HatImage",
                table: "Offers",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0bdb20fe-233a-411e-bea3-a76e09917e0f", 0, "e7c891de-0c39-4942-8f38-34444342ce98", "judith@hattfabriken.com", true, false, null, "JUDITH@HATTFABRIKEN.COM", "JUDITH@HATTFABRIKEN.COM", "AQAAAAIAAYagAAAAEJnRf7u0vddvu40ivH8rZtTBA6o58o8xK4nQ3PS5W1PDmxQRe0bhxYolwtgt/1N1tg==", null, false, "a9810ce7-688d-4d3f-95f7-de6ff28bb380", false, "judith@hattfabriken.com" },
                    { "5a8b032b-11ba-4a8e-9c33-e1c368096503", 0, "8c9c1837-27c5-4642-b718-1955007cb716", "otto@hattfabriken.com", true, false, null, "OTTO@HATTFABRIKEN.COM", "OTTO@HATTFABRIKEN.COM", "AQAAAAIAAYagAAAAEN8gwwBgGnaggwNpQy0jfE5onMXjpfeu7gTH9F2DeOZ8ZPgPD8dTFpcMB4/f4wMx1w==", null, false, "21e970eb-4ef8-488a-917f-ceb42d86243a", false, "otto@hattfabriken.com" }
                });

            migrationBuilder.InsertData(
                table: "Hats",
                columns: new[] { "HatId", "Description", "HatImage", "HatName", "HatType", "MaterialCost", "MaterialName", "OuterMeasurement", "Quantity", "SpecialEffectCost", "SpecialEffects" },
                values: new object[,]
                {
                    { 1, "A timeless choice for any formal occasion.", null, "Classic Fedora", "Fedora", 2000.0, "Leather", 58, 120, 0.0, "None" },
                    { 2, "Perfect for a sunny day out in the park or at the beach.", null, "Summer Straw Hat", "Panama", 1500.0, "Straw", 56, 85, 50.0, "Ribbon" },
                    { 3, "Ideal for weddings and formal evening events.", null, "Elegant Top Hat", "Top Hat", 3000.0, "Felt", 60, 40, 100.0, "Silk Band" },
                    { 4, "A casual wear staple, perfect for outdoor activities.", null, "Casual Baseball Cap", "Baseball Cap", 800.0, "Cotton", 57, 200, 30.0, "Embroidery" },
                    { 5, "A touch of the 1920s style to grace any sophisticated look.", null, "Vintage Cloche", "Cloche", 2500.0, "Felt", 55, 60, 45.0, "Cloth Flower" }
                });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Cloth",
                column: "Price",
                value: 1300);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Cotton",
                column: "Price",
                value: 1600);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Felt",
                column: "Price",
                value: 1400);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Leather",
                column: "Price",
                value: 4500);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Linen",
                column: "Price",
                value: 2800);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Panama",
                column: "Price",
                value: 1600);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Polyester",
                column: "Price",
                value: 1100);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Satin",
                column: "Price",
                value: 1200);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Snakeskin",
                column: "Price",
                value: 8400);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Straw",
                column: "Price",
                value: 1400);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Commentary", "Country", "Email", "EstimatedDate", "HatType", "Height", "Maker", "MaterialCost", "Name", "PhoneNumber", "PostalCode", "ShippingCost", "SpecialEffectCost", "SpecialEffects" },
                values: new object[] { "123 Elm Street", "Black color, classic style", "Sweden", "customer1@example.com", new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), "Fedora", 15, null, 5000.0, "John Doe", "123-456-7890", 10001, 200.0, 50.0, "Feathers" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Commentary", "Country", "Delivery", "Email", "EstimatedDate", "HatType", "Height", "Maker", "MaterialCost", "Measurement", "Name", "PhoneNumber", "PostalCode", "ShippingCost", "SpecialEffectCost", "SpecialEffects", "Status", "Urgent" },
                values: new object[] { "456 Oak Street", "Lightweight for summer", "Sweden", true, "customer2@example.com", new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), "Trilby", 12, null, 3000.0, 57, "Jane Smith", "987-654-3210", 10002, 150.0, 40.0, "Lace", "To-Do", true });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Commentary", "Country", "Email", "EstimatedDate", "HatType", "Height", "Maker", "MaterialCost", "Measurement", "Name", "PhoneNumber", "PostalCode", "ShippingCost", "SpecialEffectCost", "SpecialEffects" },
                values: new object[] { "789 Birch Street", "For sports and casual wear", "Sweden", "customer3@example.com", new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Local), "Baseball Cap", 10, null, 1500.0, 56, "Alice Blue", "321-456-9870", 10003, 100.0, 20.0, "Polished Paper" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Commentary", "Country", "Email", "EstimatedDate", "HatType", "Height", "Maker", "Material", "MaterialCost", "Name", "PhoneNumber", "PostalCode", "ShippingCost", "SpecialEffectCost", "SpecialEffects", "Urgent" },
                values: new object[] { "246 Pine Street", "Elegant and stylish", "Sweden", "customer4@example.com", new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Local), "Beret", 10, null, "Felt", 4500.0, "Betty White", "654-321-4567", 10004, 95.0, 70.0, "Pearls", true });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Commentary", "Country", "Email", "EstimatedDate", "HatType", "Height", "Maker", "Material", "MaterialCost", "Measurement", "Name", "PhoneNumber", "PostalCode", "ShippingCost", "SpecialEffectCost", "SpecialEffects", "Status" },
                values: new object[] { "135 Maple Street", "Vintage look", "Sweden", "customer5@example.com", new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Local), "Cloche", 12, null, "Wool", 4000.0, 55, "Carol King", "852-753-9514", 10005, 85.0, 35.0, "Cloth Flowers", "To-Do" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Commentary", "Country", "Delivery", "Email", "EstimatedDate", "HatType", "Height", "Maker", "Material", "MaterialCost", "Measurement", "Name", "PhoneNumber", "PostalCode", "ShippingCost", "SpecialEffectCost", "SpecialEffects", "Urgent" },
                values: new object[] { "369 Willow Street", "Perfect for the beach", "Sweden", false, "customer6@example.com", new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), "Panama", 12, null, "Panama", 3200.0, 60, "Dave Rich", "456-789-0123", 10006, 110.0, 40.0, "Lace", true });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Commentary", "Country", "Delivery", "Email", "EstimatedDate", "HatType", "Height", "Maker", "Material", "MaterialCost", "Measurement", "Name", "PhoneNumber", "PostalCode", "ShippingCost", "SpecialEffectCost", "SpecialEffects", "Status" },
                values: new object[] { "987 Cedar Street", "Casual and comfy", "Sweden", true, "customer7@example.com", new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Local), "Bucket Hat", 10, null, "Linen", 2700.0, 58, "Eva Storm", "789-012-3456", 10007, 80.0, 90.0, "Fake Fur", "To-Do" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Commentary", "Country", "Delivery", "Email", "EstimatedDate", "HatType", "Height", "Maker", "Material", "MaterialCost", "Measurement", "Name", "PhoneNumber", "PostalCode", "ShippingCost", "SpecialEffectCost", "SpecialEffects", "Status", "Urgent" },
                values: new object[] { "654 Spruce Street", "Retro style", "Sweden", false, "customer8@example.com", new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Local), "Newsboy Cap", 13, null, "Polyester", 2800.0, 57, "Fred Quest", "951-753-8524", 10008, 90.0, 20.0, "Polished Paper", "To-Do", true });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Commentary", "Country", "Delivery", "Email", "EstimatedDate", "HatType", "Height", "Maker", "Material", "MaterialCost", "Measurement", "Name", "PhoneNumber", "PostalCode", "ShippingCost", "SpecialEffectCost", "SpecialEffects", "Status" },
                values: new object[] { "321 Birch Street", "Elegant evening wear", "Sweden", true, "customer9@example.com", new DateTime(2024, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), "Top Hat", 20, null, "Satin", 4900.0, 59, "Gina Gold", "123-987-6543", 10009, 125.0, 70.0, "Pearls", "To-Do" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "Commentary", "Country", "Delivery", "Email", "EstimatedDate", "HatImage", "HatType", "Height", "Maker", "Material", "MaterialCost", "Measurement", "Name", "PhoneNumber", "PostalCode", "ShippingCost", "SpecialEffectCost", "SpecialEffects", "Status", "Urgent" },
                values: new object[] { 10, "852 Oak Lane", "Classic derby style", "Sweden", false, "customer10@example.com", new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), null, "Derby", 14, null, "Cloth", 3500.0, 56, "Harry Hatt", "321-654-9876", 10010, 100.0, 15.0, "Lurex Thread", "To-Do", true });

            migrationBuilder.InsertData(
                table: "SpecialEffects",
                columns: new[] { "SpecialEffectName", "Price" },
                values: new object[,]
                {
                    { "Cloth Flowers", 35.00m },
                    { "Fake Fur", 90.00m },
                    { "Feathers", 50.00m },
                    { "Lace", 40.00m },
                    { "Lurex Thread", 15.00m },
                    { "Pearls", 70.00m },
                    { "Polished Paper", 20.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0bdb20fe-233a-411e-bea3-a76e09917e0f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5a8b032b-11ba-4a8e-9c33-e1c368096503");

            migrationBuilder.DeleteData(
                table: "Hats",
                keyColumn: "HatId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hats",
                keyColumn: "HatId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hats",
                keyColumn: "HatId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hats",
                keyColumn: "HatId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hats",
                keyColumn: "HatId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SpecialEffects",
                keyColumn: "SpecialEffectName",
                keyValue: "Cloth Flowers");

            migrationBuilder.DeleteData(
                table: "SpecialEffects",
                keyColumn: "SpecialEffectName",
                keyValue: "Fake Fur");

            migrationBuilder.DeleteData(
                table: "SpecialEffects",
                keyColumn: "SpecialEffectName",
                keyValue: "Feathers");

            migrationBuilder.DeleteData(
                table: "SpecialEffects",
                keyColumn: "SpecialEffectName",
                keyValue: "Lace");

            migrationBuilder.DeleteData(
                table: "SpecialEffects",
                keyColumn: "SpecialEffectName",
                keyValue: "Lurex Thread");

            migrationBuilder.DeleteData(
                table: "SpecialEffects",
                keyColumn: "SpecialEffectName",
                keyValue: "Pearls");

            migrationBuilder.DeleteData(
                table: "SpecialEffects",
                keyColumn: "SpecialEffectName",
                keyValue: "Polished Paper");

            migrationBuilder.DropColumn(
                name: "Delivery",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "Delivery",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "HatImage",
                table: "Offers");

            migrationBuilder.AddColumn<string>(
                name: "DeliveryOrPickup",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Maker",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryOrPickup",
                table: "Offers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "460f0cba-c4b4-45c4-9278-e0f89f459c4c", 0, "a661a64d-990b-42d1-87c5-0dcb44aa5486", "otto@hattfabriken.com", true, false, null, "OTTO@HATTFABRIKEN.COM", "OTTO@HATTFABRIKEN.COM", "AQAAAAIAAYagAAAAEOf05ps90SvneccdKopgzE3iXlFBhPVGBJKlRWbgVxiQ58umpt8Ml7nrkfwog2z/yA==", null, false, "e9d5bc0a-a906-41b0-80bf-3611b12a966d", false, "otto@hattfabriken.com" },
                    { "492ec57f-9f87-482a-9919-ea02f94e3a1c", 0, "77da78d9-8537-448d-8eca-0219231d54a3", "judith@hattfabriken.com", true, false, null, "JUDITH@HATTFABRIKEN.COM", "JUDITH@HATTFABRIKEN.COM", "AQAAAAIAAYagAAAAELAD3QL8+GrqrLSpqe/MwhIc8HF517sLuKOGGTem1QiZlaTQF1igWyHqBp4fqPBcPw==", null, false, "6e3e86ff-a195-4049-9b4f-d7fdb69de256", false, "judith@hattfabriken.com" }
                });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Cloth",
                column: "Price",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Cotton",
                column: "Price",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Felt",
                column: "Price",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Leather",
                column: "Price",
                value: 45);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Linen",
                column: "Price",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Panama",
                column: "Price",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Polyester",
                column: "Price",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Satin",
                column: "Price",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Snakeskin",
                column: "Price",
                value: 84);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialName",
                keyValue: "Straw",
                column: "Price",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Commentary", "Country", "Email", "EstimatedDate", "HatType", "Height", "Maker", "MaterialCost", "Name", "PhoneNumber", "PostalCode", "ShippingCost", "SpecialEffectCost", "SpecialEffects" },
                values: new object[] { "Köpmansgatan 10", "Beställningen brådskar.", "Sverige", "kund@example.com", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, "Otto", 0.0, "Kund Namnsson", "0701234567", 12345, null, null, "Waterproof" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Commentary", "Country", "Delivery", "Email", "EstimatedDate", "HatType", "Height", "Maker", "MaterialCost", "Measurement", "Name", "PhoneNumber", "PostalCode", "ShippingCost", "SpecialEffectCost", "SpecialEffects", "Status", "Urgent" },
                values: new object[] { "Handelsgatan 20", "Extra storlek behövs.", "Sverige", false, "annan.kund@example.com", new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, "Judith", 0.0, 60, "Annan Kundsson", "0707654321", 23456, null, null, "Sunproof", "Judith-Ongoing", false });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Commentary", "Country", "Email", "EstimatedDate", "HatType", "Height", "Maker", "MaterialCost", "Measurement", "Name", "PhoneNumber", "PostalCode", "ShippingCost", "SpecialEffectCost", "SpecialEffects" },
                values: new object[] { "Blommans väg 3", "Behöver för sommarsäsongen.", "Sverige", "sommar@example.com", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, "Greta", 0.0, 57, "Sommar Svensson", "0712345678", 34567, null, null, "Pärlor" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Commentary", "Country", "Email", "EstimatedDate", "HatType", "Height", "Maker", "Material", "MaterialCost", "Name", "PhoneNumber", "PostalCode", "ShippingCost", "SpecialEffectCost", "SpecialEffects", "Urgent" },
                values: new object[] { "Vintergatan 45", "Vinterdesign önskas.", "Sverige", "vinter@example.com", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, "Hugo", "Wool", 0.0, "Vinter Vintersson", "0723456789", 45678, null, null, "Insulated", false });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Commentary", "Country", "Email", "EstimatedDate", "HatType", "Height", "Maker", "Material", "MaterialCost", "Measurement", "Name", "PhoneNumber", "PostalCode", "ShippingCost", "SpecialEffectCost", "SpecialEffects", "Status" },
                values: new object[] { "Glamourgatan 12", "För speciell gala.", "Sverige", "gala@example.com", new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, "Freja", "Silk", 0.0, 56, "Gala Galesson", "0734567890", 56789, null, null, "Shiny", "Completed" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Commentary", "Country", "Delivery", "Email", "EstimatedDate", "HatType", "Height", "Maker", "Material", "MaterialCost", "Measurement", "Name", "PhoneNumber", "PostalCode", "ShippingCost", "SpecialEffectCost", "SpecialEffects", "Urgent" },
                values: new object[] { "Snabbvägen 30", "Snabb leverans krävs.", "Sverige", true, "snabb@example.com", new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, "Otto", "Felt", 0.0, 55, "Snabb Snabbsson", "0745678901", 67890, null, null, "Stiff", false });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Commentary", "Country", "Delivery", "Email", "EstimatedDate", "HatType", "Height", "Maker", "Material", "MaterialCost", "Measurement", "Name", "PhoneNumber", "PostalCode", "ShippingCost", "SpecialEffectCost", "SpecialEffects", "Status" },
                values: new object[] { "Retrogatan 56", "Retrostil önskas.", "Sverige", false, "retro@example.com", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, "Judith", "Leather", 0.0, 61, "Retro Retrosson", "0756789012", 78901, null, null, "Vintage", "Completed" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Commentary", "Country", "Delivery", "Email", "EstimatedDate", "HatType", "Height", "Maker", "Material", "MaterialCost", "Measurement", "Name", "PhoneNumber", "PostalCode", "ShippingCost", "SpecialEffectCost", "SpecialEffects", "Status", "Urgent" },
                values: new object[] { "Solgatan 78", "Lätt och luftig för sommarbruk.", "Sverige", true, "solig@example.com", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, "Greta", "Straw", 0.0, 58, "Solig Solsson", "0767890123", 89012, null, null, "Breathable", "Completed", false });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Commentary", "Country", "Delivery", "Email", "EstimatedDate", "HatType", "Height", "Maker", "Material", "MaterialCost", "Measurement", "Name", "PhoneNumber", "PostalCode", "ShippingCost", "SpecialEffectCost", "SpecialEffects", "Status" },
                values: new object[] { "Fiskevägen 89", "Vattenavvisande för fiske.", "Sverige", false, "fiskare@example.com", new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, "Hugo", "Polyester", 0.0, 62, "Fiskare Fiskarsson", "0778901234", 90123, null, null, "Waterproof", "Completed" });
        }
    }
}
