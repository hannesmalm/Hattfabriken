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
        [HttpGet]
        public IActionResult EditHat(int HatId) 
        {
            var hat = _dbContext.Hattar.FirstOrDefault(h => h.HatId == HatId);
            if (hat == null)
            {
                return RedirectToAction(nameof(EditHat));
            }

            var editHatViewModel = new EditHatViewModel
            {
                HatId = HatId,
                MaterialName = hat.MaterialName,
                Description = hat.Description,
                Price = hat.Price,
                SpecialEffects = hat.SpecialEffects,
                OuterMeasurement = hat.OuterMeasurement,
            };
            return View("EditHat", editHatViewModel);
         }
        [HttpPost]

        public IActionResult EditHat(EditHatViewModel editHatViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var existingHat = _dbContext.Hattar.FirstOrDefault(h => h.HatId == editHatViewModel.HatId);

                    if (existingHat != null)
                    {
                        existingHat.HatName = editHatViewModel.HatName;
                        existingHat.MaterialName = editHatViewModel.MaterialName;
                        existingHat.Description = editHatViewModel.Description;
                        existingHat.Price = editHatViewModel.Price;
                        existingHat.SpecialEffects = editHatViewModel.SpecialEffects;
                        existingHat.OuterMeasurement = editHatViewModel.OuterMeasurement;
                        
                        _dbContext.SaveChanges();
                        return RedirectToAction("StorageOfHats", new { hatId = existingHat.HatId });
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ett fel uppstod: {ex.Message}");
                    return RedirectToAction("Error", "EditHat");
                }

            }
            return View("EditHat", editHatViewModel);
        }
    }
}
