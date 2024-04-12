using Hattfabriken.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hattfabriken.Controllers
{
    public class HatController : Controller
    {
        private readonly HatDbContext _dbContext;
        public HatController(HatDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var hats = _dbContext.Hattar.ToList();
            return View(hats);
        }
        public IActionResult StorageOfHats()
        {
            var hats = _dbContext.Hattar.ToList();
            return View("~/Views/Lager/StorageOfHats.cshtml", hats);
        }
        [HttpGet]
        public IActionResult AddHat()
        {
            AddHatViewModel addHatViewModel = new AddHatViewModel();
            return View(addHatViewModel);
        }

        [HttpPost]
        public IActionResult AddHat(AddHatViewModel addHatViewModel)
        {
            

            if (ModelState.IsValid)
            {
                Hatt newHat = new Hatt()
                {
                    HatName = addHatViewModel.HatName,
                    MaterialName = addHatViewModel.MaterialName,
                    OuterMeasurement = addHatViewModel.OuterMeasurement,
                    Description = addHatViewModel.Description,
                    Price = addHatViewModel.Price,
                    SpecialEffects = addHatViewModel.SpecialEffects,
                };
                _dbContext.Hattar.Add(newHat);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(StorageOfHats));
            }
            else
            {
                Console.WriteLine("KNAUS");
            }
            return View("~/Views/Lager/StorageOfHats.cshtml");
        }
    }
}
