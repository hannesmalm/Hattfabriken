using Microsoft.AspNetCore.Mvc;
using Hattfabriken.Models;

namespace Hattfabriken.Controllers
{
    public class PdfController : Controller
    {
        private readonly PdfService _pdfService;

        public PdfController(PdfService pdfService)
        {
            _pdfService = pdfService;
        }

        public IActionResult DownloadPdf()
        {
            byte[] pdf = _pdfService.GeneratePdf();
            return File(pdf, "application/pdf", "TestDokument.pdf");
        }
    }
}
