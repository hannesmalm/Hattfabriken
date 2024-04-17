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
        //public byte[] GenerateInvoice(InvoiceData data)
        //{
        //    IContainer CellStyle(IContainer container) => container
        //        .DefaultTextStyle(x => x.FontSize(12))
        //        .Padding(10)
        //        .Border(1)
        //        .BorderColor("CCCCCC");

        //    return GenerateDocument(document =>
        //    {
        //        document.Page(page =>
        //        {
        //            page.Margin(50);
        //            page.Size(PageSizes.A4);
        //            page.DefaultTextStyle(x => x.FontSize(12));

        //            // Header med företagsinformation och logotyp
        //            page.Header().Height(100).Column(column =>
        //            {
        //                column.Item().Row(row =>
        //                {
        //                    row.RelativeItem().Image(data.CompanyLogoPath, ImageScaling.FitHeight);
        //                    row.ConstantItem(250).Text(text =>
        //                    {
        //                        text.DefaultTextStyle(x => x.FontSize(10));
        //                        text.Line(data.CompanyName);
        //                        text.Line(data.CompanyAddress);
        //                        text.Line("Telefon: " + data.CompanyPhone);
        //                        text.Line("E-post: " + data.CompanyEmail);
        //                    });
        //                });
        //            });

        //            // Faktura titel och datum
        //            page.Header().Height(50).PaddingTop(30).AlignCenter().Text($"FAKTURA - #{data.InvoiceNumber}").FontSize(20);

        //            // Kundinformation
        //            page.Header().Height(60).PaddingTop(10).Column(column =>
        //            {
        //                column.Item().Text(text =>
        //                {
        //                    text.DefaultTextStyle(x => x.FontSize(12));
        //                    text.Line("Fakturerad till:");
        //                    text.Line(data.CustomerName);
        //                    text.Line(data.CustomerAddress);
        //                });
        //            });

        //            // Tabell för fakturaobjekt
        //            page.Content().Table(table =>
        //            {
        //                // Kolumnrubriker
        //                table.ColumnsDefinition(columns =>
        //                {
        //                    columns.ConstantColumn(50);
        //                    columns.RelativeColumn(1);
        //                    columns.RelativeColumn(1);
        //                    columns.RelativeColumn(1);
        //                    columns.RelativeColumn(1);
        //                });

        //                // Header-rad
        //                table.Header(header =>
        //                {
        //                    header.Cell().Element(CellStyle).Text("#");
        //                    header.Cell().Element(CellStyle).Text("Beskrivning");
        //                    header.Cell().Element(CellStyle).Text("Antal");
        //                    header.Cell().Element(CellStyle).Text("Pris/st");
        //                    header.Cell().Element(CellStyle).Text("Summa");
        //                });

        //                // Data-rader
        //                int i = 1;
        //                foreach (var item in data.Items)
        //                {
        //                    table.Row(row =>
        //                    {
        //                        row.Cell().Element(CellStyle).Text(i++.ToString());
        //                        row.Cell().Element(CellStyle).Text(item.Description);
        //                        row.Cell().Element(CellStyle).Text(item.Quantity.ToString());
        //                        row.Cell().Element(CellStyle).Text(item.UnitPrice.ToString("C2"));
        //                        row.Cell().Element(CellStyle).Text(item.TotalPrice.ToString("C2"));
        //                    });
        //                }

        //                // Totalrad
        //                table.Footer(footer =>
        //                {
        //                    footer.Cell().Element(CellStyle).AlignRight().Text("Totalt: ").Span(4); // Spans över fyra kolumner
        //                    footer.Cell().Element(CellStyle).Text(data.TotalAmount.ToString("C2"));
        //                });

        //            });

        //            // Footer med sidnummer
        //            page.Footer().Height(50).AlignCenter().Text(x =>
        //            {
        //                x.CurrentPageNumber();
        //                x.Span(" av ");
        //                x.TotalPages();
        //            });
        //        });
        //    }, data);
        //}

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
                       .Text("Shipping Lable")
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
                             row.Spacing(30);
                             row.RelativeItem().Column(c =>
                             {
                                 c.Item().Text("Sender:").Bold();
                                 c.Item().Text($"{data.CompanyName}");
                                 c.Item().Text($"{data.CompanyAddress}");
                                 c.Item().Text($"{data.CompanyCountry}");
                             });

                             row.RelativeItem().Column(c =>
                             {
                                 c.Item().Text("Receiver:").Bold();
                                 c.Item().Text($"{data.Name}");
                                 c.Item().Text($"{data.Adress}, {data.PostalCode}");
                                 c.Item().Text($"{data.Country}");

                             });

                         });

                         column.Item().Row(row =>
                         {
                             row.Spacing(30);
                             row.RelativeItem().Column(c =>
                             {
                                 c.Item().Text($"HS-Code: {data.HsCode}").LineHeight(2).Bold();
                                 c.Item().Text("Number of packages included: 1pcs").LineHeight(2).Bold();
                                 c.Item().Text("Weight: 2kg").LineHeight(2).Bold();
                                 c.Item().Text($"Order number: {data.OrderNumber}").LineHeight(2).Bold();
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

                            //// Customer Details ****Behövs inte????****
                            //column.Item()
                            //    .BorderBottom(1)
                            //    .Padding(5)
                            //    .Row(row =>
                            //    {
                            //        row.RelativeItem().Column(c =>
                            //        {
                            //            c.Item().Text("Customer:").Bold();
                            //            c.Item().Text($"{order.Name}");
                            //            c.Item().Text($"{order.Adress}, {order.PostalCode}");
                            //            c.Item().Text($"{order.Country}");
                            //        });

                            //        row.RelativeItem().Column(c =>
                            //        {
                            //            c.Item().Text("Contact:").Bold();
                            //            c.Item().Text($"Phone: {order.PhoneNumber}");
                            //            c.Item().Text($"Email: {order.Email}");
                            //        });
                            //    });

                            // Hat Details
                            column.Item()
                                .Padding(5)
                                .BorderBottom(1)
                                .Column(c =>
                                {
                                    c.Item().Text("Hat Details:").Bold();
                                    if (order.HatId != null)
                                        c.Item().Text($"Hat ID: {order.HatId}");
                                    if (!string.IsNullOrEmpty(order.Material))
                                        c.Item().Text($"Material: {order.Material}");
                                    if (order.Measurement != null)
                                        c.Item().Text($"Measurement: {order.Measurement} cm");
                                    if (order.Height != null)
                                        c.Item().Text($"Height: {order.Height} cm");
                                    if (!string.IsNullOrWhiteSpace(order.Commentary))
                                        c.Item().Text($"Commentary: {order.Commentary}");
                                });

                            // Special Effects
                            if (order.SpecialEffects?.Count > 0)
                            {
                                column.Item()
                                    .Padding(5)
                                    .Column(c =>
                                    {
                                        c.Item().Text("Special Effects:").Bold();
                                        foreach (var effect in order.SpecialEffects)
                                            c.Item().Text(effect);
                                    });
                            }

                            // Order and Delivery Details
                            column.Item()
                                .Padding(5)
                                .Column(c =>
                                {
                                    c.Item().Text("Order Details:").Bold();
                                    c.Item().Text($"To be completed by: {order.DueDate.ToShortDateString()}");
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
