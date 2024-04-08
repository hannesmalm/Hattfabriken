using Hattfabriken.Models;
using Microsoft.AspNetCore.Mvc;
using Hattfabriken.Models.ViewModels;


namespace Hattfabriken.Controllers
{

    public class RequestController : Controller
    {
        private readonly HatDbContext _context;
        public RequestController(HatDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult NewRequest()
        {
            RequestViewModel requestviewModel = new RequestViewModel();
            return View(requestviewModel);
        }

        [HttpPost]
        public async Task<IActionResult> NewRequest(RequestViewModel requestViewModel)
        {
            if (ModelState.IsValid)
            {
                Forfragan forfragan = new Forfragan
                {
                    Kommentar = requestViewModel.Kommentar,
                    Material = requestViewModel.Material,
                    Matt = requestViewModel.Matt,
                    Hojd = requestViewModel.Hojd,
                    HatId = requestViewModel.HatId,
                    Land = requestViewModel.Land,
                    Adress = requestViewModel.Adress,
                    Postnummer = requestViewModel.Postnummer,
                    Email = requestViewModel.Email,
                    Telefonnummer = requestViewModel.Telefonnummer
                };

                if (requestViewModel.SelectedSpecialEffekter != null && requestViewModel.SelectedSpecialEffekter.Any())
                {
                    forfragan.SelectedSpecialEffekter = new List<string>(requestViewModel.SelectedSpecialEffekter);
                }
                else
                {
                    forfragan.SelectedSpecialEffekter = new List<string>(); // Tom lista om ingen special effekt är vald
                }

                _context.Add(forfragan);
                await _context.SaveChangesAsync();

                return RedirectToAction("Request", "RequestSuccess");
            }

            foreach (var key in ModelState.Keys)
            {
                foreach (var error in ModelState[key].Errors)
                {
                    Console.WriteLine($"Fält: {key}, Fel: {error.ErrorMessage}");
                }
            }


            return View(requestViewModel);
        }

        public IActionResult RequestSuccess()
        {
            return View();
        }

    }
}
