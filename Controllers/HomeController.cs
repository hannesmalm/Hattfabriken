using Hattfabriken.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Hattfabriken.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult StorageOfMaterials()
        {
            // Saknar models
            return View("~/Views/Lager/StorageOfMaterials.cshtml");
        }


        //Material controller - vänta tills databasen är kopplad

        //public IActionResult StorageOfMaterials()
        //{
        //    
        //    var materials = _dbContext.Materials.ToList(); // ändra _dbContext till rätt instance

        //    return View(materials);
        //}


        //[HttpPost]
        //public IActionResult AddMaterial(Material material)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        // ändra _dbContext till rätt instance
        //        _dbContext.Materials.Add(material);
        //        _dbContext.SaveChanges();

        //        return RedirectToAction(nameof(StorageOfMaterials));
        //    }
        //    // If ModelState is not valid, return to the same view with validation errors
        //    return View(material);
        //}



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
