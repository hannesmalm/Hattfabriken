using Hattfabriken.Models;
using Hattfabriken.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SkiaSharp;

namespace Hattfabriken.Controllers
{
    public class HatController : Controller
    {
        private readonly HatDbContext _dbContext;
        private readonly IImageService _imageService;
        public HatController(HatDbContext dbContext, IImageService imageService)
        {
            _dbContext = dbContext;
            _imageService = imageService;

        }
        public IActionResult StorageOfHats()
        {
            var existingHats = _dbContext.Hats.ToList();
            return View("~/Views/Lager/StorageOfHats.cshtml", existingHats);
        }

        [HttpGet]
        public IActionResult AddHat()
        {
            var specialEffectsList = _dbContext.SpecialEffects.ToList();
            ViewBag.SpecialEffects = specialEffectsList;

            var materials = _dbContext.Materials.ToList();
            ViewBag.Materials = materials;

            AddHatViewModel addHatViewModel = new AddHatViewModel();

            {
                var SelectedSpecialEffects = new List<String>();

            }
            return View("~/Views/Lager/AddHat.cshtml", addHatViewModel);
        }

        [HttpPost]
        public async Task <IActionResult> AddHat(AddHatViewModel addHatViewModel)
        {

            if (ModelState.IsValid)
            {
                var material = _dbContext.Materials.FirstOrDefault(m => m.MaterialName == addHatViewModel.MaterialName);

                if (material != null)
                {
                    Hat newHat = new Hat()
                    {
                        HatId = addHatViewModel.HatId,
                        HatName = addHatViewModel.HatName,
                        HatType = addHatViewModel.HatType,
                        MaterialName = addHatViewModel.MaterialName,
                        OuterMeasurement = addHatViewModel.OuterMeasurement,
                        Description = addHatViewModel.Description,
                        SpecialEffects = addHatViewModel.SpecialEffects,
                        Quantity = addHatViewModel.Quantity,
                        Material = material,
                        SpecialEffectCost = addHatViewModel.SpecialEffectCost,
                        MaterialCost = addHatViewModel.MaterialCost,
                    };
                    if (addHatViewModel.HatImage != null && addHatViewModel.HatImage.Length > 0)
                    {
                        Console.WriteLine("Hattbild: " + addHatViewModel.HatImage);
                        var image = new Image
                        {
                            Data = _imageService.ConvertToByteArray(addHatViewModel.HatImage)
                        };
                        _dbContext.Add(image);
                        await _dbContext.SaveChangesAsync();
                        newHat.HatImage = image.Data;
                    }
                    _dbContext.Add(newHat);
                    await _dbContext.SaveChangesAsync();
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

        [HttpGet]
        public IActionResult EditHat(int HatId)
        {
			var hat = _dbContext.Hats.FirstOrDefault(h => h.HatId == HatId);

			if (hat == null)
            {
                return RedirectToAction("StorageOfHats", new { errorMessage = "Hat not found." });
            }

            var specialEffectsList = _dbContext.SpecialEffects.ToList();
            ViewBag.SpecialEffects = specialEffectsList;

            var materials = _dbContext.Materials.ToList();
            ViewBag.Materials = materials;

            var editHatViewModel = new EditHatViewModel
            {
                HatId = hat.HatId,
                HatName = hat.HatName,
                HatType = hat.HatType,
                MaterialName = hat.MaterialName,
                Description = hat.Description,
                SpecialEffects = hat.SpecialEffects,
                OuterMeasurement = hat.OuterMeasurement,
                Quantity = hat.Quantity,
                SpecialEffectCost = hat.SpecialEffectCost,
                MaterialCost = hat.MaterialCost,
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
                        existingHat.HatType = editHatViewModel.HatType;
                        existingHat.MaterialName = editHatViewModel.MaterialName;
                        existingHat.Description = editHatViewModel.Description;
                        existingHat.SpecialEffects = editHatViewModel.SpecialEffects;
                        existingHat.OuterMeasurement = editHatViewModel.OuterMeasurement;
                        existingHat.Quantity = editHatViewModel.Quantity;
                        existingHat.MaterialCost = editHatViewModel.MaterialCost;
                        existingHat.SpecialEffectCost = editHatViewModel.SpecialEffectCost;

                        if (editHatViewModel.HatImage != null && editHatViewModel.HatImage.Length > 0)
                        {
                            var image = new Image
                            {
                                Data = _imageService.ConvertToByteArray(editHatViewModel.HatImage)
                            };
                            _dbContext.Images.Add(image);
                            _dbContext.SaveChanges();
                            existingHat.HatImage = image.Data;
                        }

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
            var materials = _dbContext.Materials.ToList();
            ViewBag.Materials = materials;
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
