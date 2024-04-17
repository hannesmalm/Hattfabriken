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
                    EstimeratLeveransdatum = model.EstimeratLeveransdatum,
                    TotalKostnad = model.TotalKostnad
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

        public IActionResult OfferList()
        {
            var offers = new List<Offer>
            {
                 new Offer
               {
            OffertId = 1,
            KundNamn = "Kund1",
            KundMail = "filip.nyden@gmail.com",
            KundTel = "123456789",
            MaterialKostnad = 100.00,
            SpecialeffektKostnad = 20.00,
            SpecialtygKostnad = 30.00,
            FraktKostnad = 10.00,
            SkapadDatum = DateTime.Now,
            EstimeratLeveransdatum = DateTime.Now.AddDays(7),
            TotalKostnad = 160.00,

               }
            };
            //var offerList = _context.Offers.ToList(); // Hämta alla Förfrågningar från databasen
            return View(offers);
        }
    }
}
