using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Hattfabriken.Models;

namespace Hattfabriken.Controllers
{
    public class MaterialController : Controller
    {
        private readonly HatDbContext _dbContext;

        public MaterialController(HatDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var materials = _dbContext.Materials.ToList();
            return View(materials);
        }

        public IActionResult StorageOfMaterials()
        {
            var materials = _dbContext.Materials.ToList();
            return View("~/Views/Lager/StorageOfMaterials.cshtml", materials);
        }


        [HttpPost]
        public IActionResult AddMaterial(Material material)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Materials.Add(material);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(StorageOfMaterials));
            }
            return View(material);
        }

        public IActionResult EditMaterial(string id)
        {
            var material = _dbContext.Materials.FirstOrDefault(m => m.MaterialName == id);
            if (material == null)
            {
                return NotFound();
            }
            return View("~/Views/Lager/EditMaterial.cshtml", material);
        }

        [HttpPost]
        public IActionResult EditMaterial(Material material)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Materials.Update(material);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(StorageOfMaterials));
            }
            return View(material);
        }


        [HttpPost]
        public IActionResult OrderMaterial(string materialName)
        {
            var material = _dbContext.Materials.FirstOrDefault(m => m.MaterialName == materialName);
            if (material != null)
            {
                // Assume ordering 100 units, update as needed
                material.MaterialQuantity += 100;
                _dbContext.SaveChanges();
            }
            return RedirectToAction(nameof(StorageOfMaterials));
        }

    }
}