using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using QuestPDF.Helpers;


namespace Hattfabriken.Models
{
    public class PdfService
    {
        public byte[] GeneratePdf()
        {
            var document = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(50);
                    page.Size(PageSizes.A4);
                    page.DefaultTextStyle(x => x.FontSize(12));

                    page.Header().Height(50).Background("#eeeeee").AlignCenter().Text("PDF Rubrik");
                    page.Content().Column(column =>
                    {
                        column.Item().Text("Detta är innehållet i PDF-dokumentet.");
                        // Du kan lägga till mer innehåll här.
                    });
                    page.Footer().Height(50).Background("#eeeeee").AlignCenter().Text(x =>
                    {
                        x.CurrentPageNumber();
                        x.Span(" av ");
                        x.TotalPages();
                    });
                });
            });

            return document.GeneratePdf();
        }
    }
}