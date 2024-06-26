﻿using Hattfabriken.Models;
using Microsoft.AspNetCore.Mvc;
using Hattfabriken.Models.Viewmodels;
using Hattfabriken.Models.Interfaces;
using Hattfabriken.Models.ViewModels;
using NuGet.Protocol.Plugins;

namespace Hattfabriken.Controllers
{
    public class OfferController : Controller
    {
        private readonly HatDbContext _context;
        private readonly IImageService _imageService;
        private readonly RequestController _requestController;

        public OfferController(HatDbContext context, IImageService imageService, RequestController requestController)
        {
            _context = context;
            _imageService = imageService;
            _requestController = requestController;
        }

        [HttpGet]
        public IActionResult Create(int? requestId)
        {
            OfferViewModel model = new OfferViewModel();

            var materials = _context.Materials.ToList();
            ViewBag.Materials = materials;
            Console.WriteLine("Materials:");
            foreach (var material in materials)
            {
                Console.WriteLine(material.MaterialName); // Antag att Name är egenskapen du vill skriva ut
            }

            var specialEffectList = _context.SpecialEffects.ToList();
            ViewBag.SpecialEffects = specialEffectList;
            Console.WriteLine("Special Effects:");
            foreach (var specialEffect in specialEffectList)
            {
                Console.WriteLine(specialEffect.SpecialEffectName); // Antag att Name är egenskapen du vill skriva ut
            }


            Request request = _context.Requests.SingleOrDefault(r => r.Id == requestId);

            if (request != null)
            {
                Console.WriteLine("The request goes through");

                ViewBag.request = request;
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(OfferViewModel model, int? requestId)
        {
            Console.WriteLine("Method runs");

            if (ModelState.IsValid) 
            {
                Console.WriteLine("ModelState is valid");

                Offer newOffer = new Offer
                {
                    Name = model.Name,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber,
                    Address = model.Address,
                    PostalCode = model.PostalCode,
                    Country = model.Country,
                    MaterialCost = model.MaterialCost,
                    SpecialEffectCost = model.SpecialEffectCost,
                    ShippingCost = model.ShippingCost,
                    DateCreated = DateTime.Today,
                    EstimatedDeliveryDate = model.EstimatedDeliveryDate,
                    TotalCost = model.TotalCost,
                    HatType = model.HatType,
                    Material = model.Material,
                    SpecialEffect = model.SpecialEffect,
                    Measurement = model.Measurement,
                    OuterMeasurement = model.OuterMeasurement,
                    Height = model.Height,
                    HatmakerComment = model.HatmakerComment,
                    Status = model.Status,
                    Delivery = model.Delivery,
                    Urgent = model.Urgent
                };

                _context.Offers.Add(newOffer);
                await _context.SaveChangesAsync();

                Console.WriteLine("SUCCESS");
                
                ViewBag.Offer = newOffer;

                if (requestId.HasValue)
                {
                    Console.WriteLine("Förfrågan accepterad");
                    _requestController.AcceptRequest(requestId.Value);
                }

                return View("OfferSuccess");
            }

            Console.WriteLine("ModelState är inte valid");

            if (requestId.HasValue)
            {
                Console.WriteLine("Requesten är med, najs");
                // Hämta requesten här baserat på requestId
                var request = _context.Requests.SingleOrDefault(r => r.Id == requestId);
                ViewBag.request = request;
            }

            return View(model);
        }

        [HttpPost]
        public void OfferAccepted(int offerId)
        {
            Offer offer = _context.Offers.FirstOrDefault(o => o.OffertId == offerId);

            offer.Status = "Accepted";

            _context.Offers.Update(offer);
            _context.SaveChangesAsync();
        }

        [HttpPost]
        public RedirectToActionResult OfferDeclined(int offerId)
        {
            Offer offer = _context.Offers.FirstOrDefault(o => o.OffertId == offerId);

            offer.Status = "Declined";

            _context.Offers.Update(offer);
            _context.SaveChangesAsync();

            return RedirectToAction("OfferList", "Offer");
        }

        public IActionResult OfferList()
        {
            var offers = new List<Offer>();
            //{
            //   new Offer
            //   {
            //        OffertId = 1,
            //        Name = "Kund1",
            //        Email = "kund1@example.com",
            //        PhoneNumber = "123456789",
            //        HatType = 1,
            //        SpecialEffectCost = 20.00,
            //        MaterialCost = 100,
            //        ShippingCost = 10.00,
            //        DateCreated = DateTime.Now,
            //        EstimatedDeliveryDate = DateTime.Now.AddDays(7),
            //        TotalCost = 160.00,
            //   }
            //};

            var offerList = _context.Offers.ToList(); // Hämta alla Förfrågningar från databasen
            return View(offerList);
        }
    }
}
