using Microsoft.AspNetCore.Mvc;
using Hattfabriken.Models.Viewmodels;

namespace Hattfabriken.Controllers
{
    public class OfferController : Controller
    {
        public IActionResult Create() 
        { 
            return View();
        
        }

        [HttpPost]
        public IActionResult Create(OfferViewModel model)
        {
            if (ModelState.IsValid) 
            {

                var nyOffert = new OfferViewModel
                {
                    KundNamn = model.KundNamn,
                    KundMail = model.KundMail,
                    OffertId = model.OffertId,
                    MaterialKostnad = model.MaterialKostnad,
                    SpecialeffektKostnad = model.SpecialeffektKostnad,
                    SpecialtygKostnad = model.SpecialtygKostnad,
                    FraktKostnad = model.FraktKostnad,
                    EstimeratLeveransdatum = model.EstimeratLeveransdatum

                };


                return RedirectToAction("FormOffer");

            }

            return View(model);


        
        }

        public IActionResult FormOffer() 
        {
            return View();
        
        }

       
    }
}
