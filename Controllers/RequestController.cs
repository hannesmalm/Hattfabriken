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
                Request forfragan = new Request
                {
                    Commentary = requestViewModel.Commentary,
                    Material = requestViewModel.Material,
                    Measurement = requestViewModel.Measurement,
                    Height = requestViewModel.Height,
                    HatId = requestViewModel.HatId,
                    Country = requestViewModel.Country,
                    Adress = requestViewModel.Adress,
                    PostalCode = requestViewModel.PostalCode,
                    Email = requestViewModel.Email,
                    PhoneNumber = requestViewModel.PhoneNumber,
                    Name = requestViewModel.Name
                };

                if (requestViewModel.SelectedSpecialEffekter != null && requestViewModel.SelectedSpecialEffekter.Any())
                {
                    forfragan.SpecialEffects = new List<string>(requestViewModel.SelectedSpecialEffekter);
                }
                else
                {
                    forfragan.SpecialEffects = new List<string>(); // Tom lista om ingen special effekt är vald
                }

                _context.Add(forfragan);
                await _context.SaveChangesAsync();

                return RedirectToAction("RequestSuccess", "Request");
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
