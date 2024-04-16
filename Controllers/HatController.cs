using Hattfabriken.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            List<SelectListItem> materials = _dbContext.Materials
                    .Select(m => new SelectListItem { Text = m.MaterialName, Value = m.MaterialName })
                    .ToList(); ViewBag.Materials = materials;
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

                    if (existingHat != null)
                    {
                        existingHat.HatName = editHatViewModel.HatName;
                        existingHat.MaterialName = editHatViewModel.MaterialName;
                        existingHat.Description = editHatViewModel.Description;
                        existingHat.Price = editHatViewModel.Price;
                        existingHat.SpecialEffects = editHatViewModel.SpecialEffects;
                        existingHat.OuterMeasurement = editHatViewModel.OuterMeasurement;

                        _dbContext.Hattar.Update(existingHat);
                        _dbContext.SaveChanges();
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

        [HttpGet]
        public IActionResult DeleteHat(int HatId)
        {
            var hat = _dbContext.Hattar.FirstOrDefault(h => h.HatId == HatId);

            if (hat == null)
            {
                return RedirectToAction("StorageOfHats", new { errorMessage = "Hat not found." });
            }
            return View("~/Views/Lager/DeleteHat.cshtml", hat);
        }

        [HttpPost]
        public IActionResult DeleteHatConfirmed(int HatId)
        {
            var hat = _dbContext.Hattar.FirstOrDefault(h => h.HatId == HatId);

            if (hat == null)
            {
                return RedirectToAction("StorageOfHats", new { errorMessage = "Hat not found." });
            }

            _dbContext.Hattar.Remove(hat);
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(StorageOfHats));

        }
    }
}
