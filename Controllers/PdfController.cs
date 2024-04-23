using Microsoft.AspNetCore.Mvc;
using Hattfabriken.Models;
using Hattfabriken.Models.DTOs;


namespace Hattfabriken.Controllers
{
    public class PdfController : Controller
    {
        private readonly PdfService _pdfService;
        private readonly HatDbContext _context;

        public PdfController(PdfService pdfService, HatDbContext context)
        {
            _pdfService = pdfService;
            _context = context;
        }

        [HttpPost]
        public IActionResult CreateShippingLabelPdf(int orderId)
        {
            Order order = _context.Orders.FirstOrDefault(o => o.Id == orderId);
            if (order == null)
            {
                return NotFound();
            }

            var data = new ShippingLabelData
            {
                Name = order.Name,
                Adress = order.Address,
                PostalCode = order.PostalCode,
                Country = order.Country,
                OrderNumber = order.Id,
            };

            byte[] pdf = _pdfService.GenerateShippingLabel(data);
            var contentDispositionHeader = new System.Net.Mime.ContentDisposition
            {
                FileName = "Invoice.pdf",
                Inline = true  // False = prompt the user for downloading; True = try to open in web browser.
            };
            Response.Headers.Add("Content-Disposition", contentDispositionHeader.ToString());
            return File(pdf, "application/pdf");
        }

        [HttpPost]
        public IActionResult CreateInvoicePdf(int orderId)
        {
            Order order = _context.Orders.FirstOrDefault(o => o.Id == orderId);
            if (order == null)
            {
                return NotFound();
            }

            var data = new InvoiceData
            {
                CustomerName = order.Name,
                CustomerAddress = order.Address,
                CustomerPostalCode = order.PostalCode,
                CustomerCountry = order.Country,
                OrderNumber = order.Id,
                MaterialCost = order.MaterialCost,
                SpecialEffectCost = order.SpecialEffectCost,
                ShippingCost = order.ShippingCost ?? 0,
                TotalAmount = order.MaterialCost + (order.SpecialEffectCost ?? 0) + (order.ShippingCost ?? 0),
            };

            byte[] pdf = _pdfService.GenerateInvoice(data);
            var contentDispositionHeader = new System.Net.Mime.ContentDisposition
            {
                FileName = "Invoice.pdf",
                Inline = true  // False = prompt the user for downloading; True = try to open in web browser.
            };
            Response.Headers.Add("Content-Disposition", contentDispositionHeader.ToString());
            return File(pdf, "application/pdf");
        }

        //[HttpPost]
        //public IActionResult CreateOrderPdf(Offer offer)
        //{
        //    var data = new OrderData
        //    {
        //        HatId = offer.HatId,
        //        Material = offer.Material,
        //        Measurement = offer.Measurement,
        //        Height = offer.Height,
        //        Commentary = offer.Commentary,
        //        HatImage = HatImage,
        //        Date = offer.EstimeratLeveransdatum,
        //        Urgent = offer.Urgent
        //    };

        //    Generate PDF
        //    byte[] pdf = _pdfService.GenerateHatOrderDocument(data);
        //    var contentDispositionHeader = new System.Net.Mime.ContentDisposition
        //    {
        //        FileName = "TestDokument.pdf",
        //        Inline = true  // False = prompt the user for downloading; True = try to open in web browser.
        //    };
        //    Response.Headers.Add("Content-Disposition", contentDispositionHeader.ToString());
        //    return File(pdf, "application/pdf");
        //}
    }
}
