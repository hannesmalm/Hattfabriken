﻿using Microsoft.AspNetCore.Mvc;
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

        public IActionResult CreateShippingLablePdf(Offer offer)
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

        //[HttpPost]
        //public IActionResult CreateOrderPdf(Offer offer)
        //{
        //    var data = new OrderData
        //    {
        //        HatId = offer.HatId,
        //        Material = offer.Material,
        //        Measurement = offer.Measurement,
        //        Height = offer.´Height,
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
