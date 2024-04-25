using Hattfabriken.Models.DTOs;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.ComponentModel;

namespace Hattfabriken.Models
{
    public class PdfService
    {
        private byte[] GenerateDocument(Action<IDocumentContainer> buildDocument)
        {
            var document = Document.Create(buildDocument);


            return document.GeneratePdf();
        }
        public byte[] GenerateInvoice(InvoiceData data)
        {
            return GenerateDocument(document =>
            {
                document.Page(page =>
                {
                    page.Margin(1, Unit.Centimetre);
                    page.Size(PageSizes.A4);

                    page.Header()
                        .BorderHorizontal(1)
                        .Height(50) // Increase the height if necessary to fit content
                        .Row(row =>
                        {
                            row.RelativeColumn(1).Column(column =>
                            {
                                column.Item()
                                      .AlignLeft()
                                      .Height(50)  // Set height of the container that will hold the image
                                      .Width(50)   // Set width of the container
                                      .Image(data.CompanyLogoPath); // Path to the image file
                            });

                            row.RelativeColumn(3).Column(column => // Use more space for text
                            {
                                column.Item().Text("Invoice").Bold().FontSize(30).FontColor(Colors.Black);
                            });
                        });

                    page.Content()
                        .BorderHorizontal(1)
                        .Column(column =>
                        {
                            column.Spacing(15);

                            column.Item()
                            .BorderHorizontal(1)
                            .Row(row =>
                            {
                                row.Spacing(20);
                                row.RelativeItem().Column(c =>
                                {
                                    c.Item().Text("From:").Bold().FontSize(14);
                                    c.Item().Text($"{data.CompanyName}");
                                    c.Item().Text($"{data.CompanyAddress}");
                                    c.Item().Text($"{data.CompanyCountry}");
                                    c.Item().Text($"Email: {data.CompanyEmail}");
                                    c.Item().Text($"Phone: {data.CompanyPhone}");
                                });

                                row.RelativeItem().Column(c =>
                                {
                                    c.Item().Text("To:").Bold().FontSize(14);
                                    c.Item().Text($"{data.CustomerName}");
                                    c.Item().Text($"{data.CustomerAddress}, {data.CustomerPostalCode}");
                                    c.Item().Text($"{data.CustomerCountry}");
                                });
                            });

                            // Include financial details
                            column.Item().Row(row =>
                            {
                                row.Spacing(20);
                                row.RelativeItem().Column(c =>
                                {
                                    if (data.InvoiceNumber.HasValue)
                                        c.Item().Text($"Invoice Number: {data.InvoiceNumber.Value}").LineHeight(2).Bold().FontSize(12);
                                    c.Item().Text($"Order Number: #{data.OrderNumber}").LineHeight(2).Bold().FontSize(12);
                                    c.Item().Text($"Due Date: {data.DueDate.ToShortDateString()}").LineHeight(2).Bold().FontSize(12);
                                    c.Item().PaddingTop(30);
                                    c.Item().Text("Material Costs: " + data.MaterialCost.ToString("0.00") + "kr").LineHeight(2).Bold().FontSize(12);
                                    // Special Effect Costs (if applicable)
                                    if (data.SpecialEffectCost.HasValue)
                                        c.Item().Text("Special Effect Costs: " + data.SpecialEffectCost.Value.ToString("0.00") + "kr").LineHeight(2).Bold().FontSize(12);

                                    // Shipping Costs
                                    c.Item().Text("Shipping Costs: " + data.ShippingCost.ToString("0.00") + "kr").LineHeight(2).Bold().FontSize(12);

                                    // Total Amount - Make it stand out
                                    c.Item().Padding(5) // Add padding around the text for emphasis
                                       .Border(1) // Add a border around the text
                                       .BorderColor(Colors.Black) // Set the color of the border
                                       .Text("Total Amount: " + data.TotalAmount.ToString("0.00") + "kr")
                                       .LineHeight(2)
                                       .Bold()
                                       .FontSize(14); // Increase the font size to make it more prominent
                                });
                            });
                        });
                });
            });
        }


        public byte[] GenerateShippingLabel(ShippingLabelData data)
        {
            return GenerateDocument(document =>
            {
                document.Page(page =>
                {
                    page.Margin(1, QuestPDF.Infrastructure.Unit.Centimetre);
                    page.Size(PageSizes.A5);

                    page.Header()
                       .BorderHorizontal(1)
                       .Height(60)
                       .AlignCenter()
                       .Text("Shipping Label")
                       .Bold().FontSize(30)
                       .FontColor(Colors.Black);

                    page.Content()
                     .BorderHorizontal(1)
                     .Column(column =>
                     {
                         column.Spacing(15);

                         column.Item()
                         .BorderHorizontal(1)
                         .Row(row =>
                         {
                             row.Spacing(20);
                             row.RelativeItem().Column(c =>
                             {
                                 c.Item().Text("Sender:").Bold().FontSize(14);
                                 c.Item().Text($"{data.CompanyName}");
                                 c.Item().Text($"{data.CompanyAddress}");
                                 c.Item().Text($"{data.CompanyCountry}");
                             });

                             row.RelativeItem().Column(c =>
                             {
                                 c.Item().Text("Receiver:").Bold().FontSize(14);
                                 c.Item().Text($"{data.Name}");
                                 c.Item().Text($"{data.Adress}, {data.PostalCode}");
                                 c.Item().Text($"{data.Country}");

                             });

                         });

                         column.Item().Row(row =>
                         {
                             row.Spacing(20);
                             row.RelativeItem().Column(c =>
                             {
                                 c.Item().Text($"Order number #{data.OrderNumber}").LineHeight(2).Bold().FontSize(12);
                                 c.Item().Text($"HS-Code: {data.HsCode}").LineHeight(2).Bold().FontSize(12);
                                 c.Item().Text("Number of packages included: 1pcs").LineHeight(2).Bold().FontSize(12);
                                 c.Item().Text("Weight: 2kg").LineHeight(2).Bold().FontSize(12);
                             });
                         });
                     });
                });
            });
        }

        public byte[] GenerateHatOrderDocument(OrderData order)
        {
            return GenerateDocument(document =>
            {
                document.Page(page =>
                {
                    page.Margin(1, Unit.Centimetre);
                    page.Size(PageSizes.A5);

                    page.Header()
                        .BorderHorizontal(1)
                        .Height(50)
                        .AlignCenter()
                        .Text($"Order ID: {order.Id}")
                        .Bold().FontSize(24)
                        .FontColor(Colors.Black);

                    page.Content()
                        .Column(column =>
                        {
                            column.Spacing(10);

                            // Hat Details
                            column.Item()
                                .Padding(5)
                                .BorderBottom(1)
                                .Column(c =>
                                {
                                    c.Item().Text("Hat Details:").Bold();
                                    if (order.HatType != null)
                                        c.Item().Text($"Hat Type: {order.HatType}");
                                    if (!string.IsNullOrEmpty(order.Material))
                                        c.Item().Text($"Material: {order.Material}");
                                    if (order.SpecialEffects != null)
                                        c.Item().Text($"Special Effect: {order.SpecialEffects}");
                                    if (order.Measurement != null)
                                        c.Item().Text($"Measurement: {order.Measurement} cm");
                                    if (order.Height != null)
                                        c.Item().Text($"Height: {order.Height} cm");
                                    if (!string.IsNullOrWhiteSpace(order.Commentary))
                                        c.Item().Text($"Commentary: {order.Commentary}");
                                });

                            // Order and Delivery Details
                            column.Item()
                                .Padding(5)
                                .Column(c =>
                                {
                                    c.Item().Text("Order Details:").Bold();
                                    c.Item().Text($"To be completed by: {order.EstimatedDate.ToShortDateString()}");
                                    c.Item().Text($"Urgent Delivery: {(order.Urgent ? "Yes" : "No")}");
                                });
                        });

                    page.Footer()
                        .AlignCenter()
                        .Text(x =>
                        {
                            x.CurrentPageNumber();
                            x.Span(" of ");
                            x.TotalPages();
                        });
                });
            });
        }
    }
}
