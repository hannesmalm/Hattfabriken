using Hattfabriken.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SkiaSharp;

namespace Hattfabriken.Controllers
{
    public class HatController : Controller
    {
        private readonly HatDbContext _dbContext;
        public HatController(HatDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult StorageOfHats()
        {
            var existingHats = _dbContext.Hats
                .Select(hat => new HatViewModel
                {
                    HatId = hat.HatId,
                    HatName = hat.HatName,
                    MaterialName = hat.MaterialName,
                    Description = hat.Description,
                    Price = hat.Price,
                    SpecialEffects = hat.SpecialEffects,
                    OuterMeasurement = hat.OuterMeasurement,
                    Quantity = hat.Quantity
                })
                .ToList();

            return View("~/Views/Lager/StorageOfHats.cshtml", existingHats);
        }
        [HttpGet]
        public IActionResult AddHat()
        {
            var specialEffectsList = _dbContext.SpecialEffects.ToList();
            ViewBag.SpecialEffects = specialEffectsList;

            var materials = _dbContext.Materials.ToList();
            ViewBag.Materials = materials;

            Console.WriteLine("Material:" + materials);

            AddHatViewModel addHatViewModel = new AddHatViewModel();

            {
                var SelectedSpecialEffects = new List<String>();

            }
            return View("~/Views/Lager/AddHat.cshtml", addHatViewModel);
        }

        [HttpPost]
        public IActionResult AddHat(AddHatViewModel addHatViewModel)
        {
            Console.WriteLine(addHatViewModel.MaterialName);

            if (ModelState.IsValid)
            {
                var material = _dbContext.Materials.FirstOrDefault(m => m.MaterialName == addHatViewModel.MaterialName);

                if (material != null)
                {
                    Hat newHat = new Hat()
                    {
                        HatId = addHatViewModel.HatId,
                        HatName = addHatViewModel.HatName,
                        MaterialName = addHatViewModel.MaterialName,
                        OuterMeasurement = addHatViewModel.OuterMeasurement,
                        Description = addHatViewModel.Description,
                        Price = addHatViewModel.Price,
                        SpecialEffects = addHatViewModel.SpecialEffects,
                        Quantity = addHatViewModel.Quantity,
                        Material = material  
                    };
                    _dbContext.Hats.Add(newHat);
                    _dbContext.SaveChanges();
                    return RedirectToAction(nameof(StorageOfHats));
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "The selected material does not exist.");
                }
            }

            var specialEffectsList = _dbContext.SpecialEffects.ToList();
            ViewBag.SpecialEffects = specialEffectsList;

            var materials = _dbContext.Materials.ToList();
            ViewBag.Materials = materials;
            return View("~/Views/Lager/AddHat.cshtml", addHatViewModel);
        }


        ////[HttpGet]
        ////public IActionResult EditHat(int HatId) 
        ////{
        ////    var hat = _dbContext.Hattar.FirstOrDefault(h => h.HatId == HatId);

        ////    if (hat == null)
        ////    {
        ////        return RedirectToAction("StorageOfHats", new { errorMessage = "Hat not found." });
        ////    }

        ////    var editHatViewModel = new EditHatViewModel
        ////    {
        ////        HatId = hat.HatId,
        ////        HatName = hat.HatName,
        ////        MaterialName = hat.MaterialName,
        ////        Description = hat.Description,
        ////        Price = hat.Price,
        ////        SpecialEffects = hat.SpecialEffects,
        ////        OuterMeasurement = hat.OuterMeasurement,
        ////        Quantity = hat.Quantity,    
        ////    };
        ////    return View("~/Views/Lager/EditHat.cshtml", editHatViewModel); 

        ////}
        [HttpGet]
        public IActionResult EditHat(int HatId)
        {
			var hat = _dbContext.Hats.FirstOrDefault(h => h.HatId == HatId);

			if (hat == null)
            {
                return RedirectToAction("StorageOfHats", new { errorMessage = "Hat not found." });
            }

            //var materials = _dbContext.Materials.Select(m => m.MaterialName).ToList();
            //ViewBag.Materials = materials;
            var specialEffectsList = _dbContext.SpecialEffects.ToList();
            ViewBag.SpecialEffects = specialEffectsList;

            var materials = _dbContext.Materials.ToList();
            ViewBag.Materials = materials;

            var editHatViewModel = new EditHatViewModel
            {
                HatId = hat.HatId,
                HatName = hat.HatName,
                MaterialName = hat.MaterialName,
                Description = hat.Description,
                Price = hat.Price,
                SpecialEffects = hat.SpecialEffects,
                OuterMeasurement = hat.OuterMeasurement,
                Quantity = hat.Quantity,
            };

            {
                var SelectedSpecialEffects = new List<String>();

            }

            return View("~/Views/Lager/EditHat.cshtml", editHatViewModel);
        }

        [HttpPost]
        public IActionResult EditHat(EditHatViewModel editHatViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    var existingHat = _dbContext.Hats.FirstOrDefault(h => h.HatId == editHatViewModel.HatId);

                    if (existingHat != null)
                    {
                        existingHat.HatName = editHatViewModel.HatName;
                        existingHat.MaterialName = editHatViewModel.MaterialName;
                        existingHat.Description = editHatViewModel.Description;
                        existingHat.Price = editHatViewModel.Price;
                        existingHat.SpecialEffects = editHatViewModel.SpecialEffects;
                        existingHat.OuterMeasurement = editHatViewModel.OuterMeasurement;
                        existingHat.Quantity = editHatViewModel.Quantity;

                        _dbContext.Hats.Update(existingHat);
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
            var specialEffectsList = _dbContext.SpecialEffects.ToList();
            ViewBag.SpecialEffects = specialEffectsList;
            return View("~/Views/Lager/EditHat.cshtml", editHatViewModel);
        }

        [HttpGet]
        public IActionResult DeleteHat(int HatId)
        {
            var hat = _dbContext.Hats.FirstOrDefault(h => h.HatId == HatId);

            if (hat == null)
            {
                return RedirectToAction("StorageOfHats", new { errorMessage = "Hat not found." });
            }
            return View("~/Views/Lager/DeleteHat.cshtml", hat);
        }

        [HttpPost]
        public IActionResult DeleteHatConfirmed(int HatId)
        {
            var hat = _dbContext.Hats.FirstOrDefault(h => h.HatId == HatId);

            if (hat == null)
            {
                return RedirectToAction("StorageOfHats", new { errorMessage = "Hat not found." });
            }

            _dbContext.Hats.Remove(hat);
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(StorageOfHats));

        }
    }
}
