using Hattfabriken.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hattfabriken.Controllers
{

    public class RequestController : Controller
    {
        private readonly HatDbContext _context;
        public RequestController(HatDbContext context)
        {
            _context = context;
        }

        public IActionResult NewRequest()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RequestThru()
        {
            //var forfragan = new Forfragan();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RequestThru(Forfragan forfragan)
        {
            if (!ModelState.IsValid)
            {
                if (Request.Form["Fjader"].Count > 0)
                {
                    forfragan.SpecialEffekter += "Fjäder, ";
                }
                if (Request.Form["Spets"].Count > 0)
                {
                    forfragan.SpecialEffekter += "Spets, ";
                }
                if (Request.Form["Parlor"].Count > 0)
                {
                    forfragan.SpecialEffekter += "Pärlor, ";
                }
                if (Request.Form["Blomma"].Count > 0)
                {
                    forfragan.SpecialEffekter += "Blomma, ";
                }

                if (!string.IsNullOrEmpty(forfragan.SpecialEffekter))
                {
                    forfragan.SpecialEffekter = forfragan.SpecialEffekter.TrimEnd(',', ' ');
                }

                if (Request.Form["Lader"].Count > 0)
                {
                    forfragan.Material += "Läder, ";
                }
                if (Request.Form["Tyg"].Count > 0)
                {
                    forfragan.Material += "Tyg, ";
                }
                if (Request.Form["Skinn"].Count > 0)
                {
                    forfragan.Material += "Skinn, ";
                }
                if (Request.Form["Stra"].Count > 0)
                {
                    forfragan.Material += "Strå, ";
                }

                if (!string.IsNullOrEmpty(forfragan.Material))
                {
                    forfragan.Material = forfragan.Material.TrimEnd(',', ' ');
                }

                if (int.TryParse(Request.Form["HatId"], out int hatId))
                {
                    forfragan.HatId = hatId;
                }
                else
                {
                    ModelState.AddModelError("HatId", "Ogiltigt värde för HatId");
                }

                forfragan.Land = Request.Form["Land"];

                forfragan.Kommentar = Request.Form["Kommentar"];

                if (int.TryParse(Request.Form["Matt"], out int matt))
                {
                    forfragan.Matt = matt;
                }
                else
                {
                    ModelState.AddModelError("Matt", "Ogiltigt värde för Matt");
                }

                if (int.TryParse(Request.Form["Hojd"], out int hojd))
                {
                    forfragan.Hojd = hojd;
                }
                else
                {
                    ModelState.AddModelError("Hojd", "Ogiltigt värde för Hojd");
                }

                forfragan.Adress = Request.Form["Adress"];

                if (int.TryParse(Request.Form["Postnummer"], out int postnummer))
                {
                    forfragan.Postnummer = postnummer;
                }
                else
                {
                    ModelState.AddModelError("Postnummer", "Ogiltigt värde för Postnummer");
                }

                forfragan.Email = Request.Form["Email"];

                if (int.TryParse(Request.Form["Telefonnummer"], out int telefonnummer))
                {
                    forfragan.Telefonnummer = telefonnummer;
                }
                else
                {
                    ModelState.AddModelError("Telefonnummer", "Ogiltigt värde för Telefonnummer");
                }

                _context.Add(forfragan);
                await _context.SaveChangesAsync();

                return RedirectToAction("RequestSuccess");
            }
            return View(forfragan);
        }

        public IActionResult RequestSuccess()
        {
            return View();
        }

    }
}
