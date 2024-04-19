using Hattfabriken.Models;
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
                    Measurement = model.Measurement,
                    Height = model.Height,
                    HatmakerComment = model.HatmakerComment,
                    Status = model.Status,
                    DeliveryOrPickup = model.DeliveryOrPickup,
                    Urgent = model.Urgent
                };

                if (model.SpecialEffects != null && model.SpecialEffects.Any())
                {
                    newOffer.SpecialEffects = new List<string>(model.SpecialEffects);
                }
                else
                {
                    newOffer.SpecialEffects = new List<string>(); // Tom lista om ingen special effekt är vald
                }

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
