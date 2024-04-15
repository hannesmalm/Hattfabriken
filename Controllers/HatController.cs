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
            Console.WriteLine("Hatt hittad");

            if (hat == null)
            {
                Console.WriteLine("Hatt inte hittad");
                return RedirectToAction("StorageOfHats", new { errorMessage = "Hat not found." });
            }

            var editHatViewModel = new EditHatViewModel
            {
                HatId = hat.HatId,
                HatName = hat.HatName,
                MaterialName = hat.MaterialName,
                Description = hat.Description,
                Price = hat.Price,
                SpecialEffects = hat.SpecialEffects,
                OuterMeasurement = hat.OuterMeasurement
            };
            Console.WriteLine("editHatViewModel: " + editHatViewModel.HatId);
            return View("~/Views/Lager/EditHat.cshtml", editHatViewModel); // Ange den fullständiga sökvägen till vyn här

        }

        [HttpPost]
        public IActionResult EditHat(EditHatViewModel editHatViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var existingHat = _dbContext.Hattar.FirstOrDefault(h => h.HatId == editHatViewModel.HatId);
                    Console.WriteLine("editHatViewModel: " + editHatViewModel.HatId);

                    Console.WriteLine("existingHat: " + existingHat);


                    if (existingHat != null)
                    {
                        existingHat.HatName = editHatViewModel.HatName;
                        existingHat.MaterialName = editHatViewModel.MaterialName;
                        existingHat.Description = editHatViewModel.Description;
                        existingHat.Price = editHatViewModel.Price;
                        existingHat.SpecialEffects = editHatViewModel.SpecialEffects;
                        existingHat.OuterMeasurement = editHatViewModel.OuterMeasurement;

                        //_dbContext.Entry(existingHat).State = EntityState.Modified;
                        Console.WriteLine("Värden tilldelade");

                        _dbContext.Hattar.Update(existingHat);
                        Console.WriteLine("Uppdaterad");

                        _dbContext.SaveChanges();
                        Console.WriteLine("Sparad");

                        return RedirectToAction(nameof(StorageOfHats));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ett fel uppstod: {ex.Message}");
                    return RedirectToAction("Error", "Home");
                }

            }
            return View("~/Views/Lager/EditHat.cshtml", editHatViewModel);
        }
    }
}
