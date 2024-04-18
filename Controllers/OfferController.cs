using Hattfabriken.Models;
using Microsoft.AspNetCore.Mvc;
using Hattfabriken.Models.Viewmodels;
using Hattfabriken.Models.Interfaces;

namespace Hattfabriken.Controllers
{
    public class OfferController : Controller
    {
        private readonly HatDbContext _context;
        private readonly IImageService _imageService;

        public OfferController(HatDbContext context, IImageService imageService)
        {
            _context = context;
            _imageService = imageService;
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
        public async Task<IActionResult> Create(OfferViewModel model)
        {
            Console.WriteLine("Method runs");

            if (ModelState.IsValid) 
            {
                Console.WriteLine("ModelState is valid");

                Offer newOffer = new Offer
                {
                    CustomerName = model.CustomerName,
                    CustomerMail = model.CustomerMail,
                    CustomerTel = model.CustomerTel,
                    MaterialCost = model.MaterialCost,
                    SpecialEffectCost = model.SpecialEffectCost,
                    SpecialFabricCost = model.SpecialFabricCost,
                    ShippingCost = model.ShippingCost,
                    CreatedDate = DateTime.Today,
                    EstimatedDeliveryDate = model.EstimatedDeliveryDate
                };

                _context.Offers.Add(newOffer);
                await _context.SaveChangesAsync();

                Console.WriteLine("SUCCESS");

                ViewBag.Offer = newOffer;
                return View("OfferSuccess");
            }

            Console.WriteLine("ModelState är inte valid");

            return View(model);
        } 
    }
}
