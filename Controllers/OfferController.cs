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
                Console.WriteLine("Requesten är med, najs");

                // Lägg till objektet i ViewBag
                ViewBag.request = request;
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(OfferViewModel model)
        {
            Console.WriteLine("Metod körs");

            if (ModelState.IsValid) 
            {
                Console.WriteLine("ModelState är valid");

                Offer nyOffert = new Offer
                {
                    KundNamn = model.KundNamn,
                    KundMail = model.KundMail,
                    KundTel = model.KundTel,
                    MaterialKostnad = model.MaterialKostnad,
                    SpecialeffektKostnad = model.SpecialeffektKostnad,
                    SpecialtygKostnad = model.SpecialtygKostnad,
                    FraktKostnad = model.FraktKostnad,
                    SkapadDatum = DateTime.Today,
                    EstimeratLeveransdatum = model.EstimeratLeveransdatum
                };

                _context.Offers.Add(nyOffert);
                await _context.SaveChangesAsync();

                Console.WriteLine("SUCCESS");

                ViewBag.Offer = nyOffert;
                return View("OfferSuccess");
            }

            Console.WriteLine("ModelState är inte valid");

            return View(model);
        } 
    }
}
