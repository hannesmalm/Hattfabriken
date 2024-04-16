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
        //            page.Header().Height(50).PaddingTop(30).AlignCenter().Text($"FAKTURA - {data.InvoiceNumber}").FontSize(20);

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

        public byte[] GenerateShippingLable()
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
                                 c.Item().Text("The Hat Factory");
                                 c.Item().Text("Adress 1 111 11");
                                 c.Item().Text("Hattorp");
                             });

                             row.RelativeItem().Column(c =>
                             {
                                 c.Item().Text("Receiver:").Bold();
                                 c.Item().Text("***");
                                 c.Item().Text("***");
                                 c.Item().Text("***");

                             });

                         });

                         column.Item().Row(row =>
                         {
                             row.Spacing(30);
                             row.RelativeItem().Column(c =>
                             {
                                 c.Item().Text("Product code: ***").LineHeight(2).Bold();
                                 c.Item().Text("Number of packages included: ***pcs").LineHeight(2).Bold();
                                 c.Item().Text("Weight: ***kg").LineHeight(2).Bold();
                                 c.Item().Text("Order number: ***").LineHeight(2).Bold();
                                 c.Item().Text("HS-CODE: ***").LineHeight(2).Bold();
                             });

                         });




                    });
                });
            });
        }

        //public byte[] GenerateOrder(OrderData data)
        //{
        //    return GenerateDocument(document =>
        //    {
        //        // Här kan du definiera layout och innehåll för beställningen
        //    }, data);
        //}
    }
}
