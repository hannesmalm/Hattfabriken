using Microsoft.AspNetCore.Mvc;
using Hattfabriken.Models;
using Hattfabriken.Models.DTOs;

namespace Hattfabriken.Controllers
{
    public class PdfController : Controller
    {
        private readonly PdfService _pdfService;

        public PdfController(PdfService pdfService)
        {
            _pdfService = pdfService;
        }

        public IActionResult CreateShippingLablePdf()
        {
            byte[] pdf = _pdfService.GenerateShippingLable();
            var contentDispositionHeader = new System.Net.Mime.ContentDisposition
            {
                FileName = "TestDokument.pdf",
                Inline = true  // False = prompt the user for downloading; True = try to open in web browser.
            };
            Response.Headers.Add("Content-Disposition", contentDispositionHeader.ToString());
            return File(pdf, "application/pdf");
        }
    }
}
