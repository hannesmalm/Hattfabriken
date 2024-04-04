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

            //// s�tt r�tt db Instance
            //var materials = _dbContext.Materials.ToList();  
            //if (materials == null)
            //{
            //    // Hantera null cases
            //    // returnerar en tom lista om model is null
            //    materials = new List<Material>();
            //}
            // Saknar models
            return View("~/Views/Lager/StorageOfMaterials.cshtml");
        }


        //Material controller - v�nta tills databasen �r kopplad

        //public IActionResult StorageOfMaterials()
        //{
        //    
        //    var materials = _dbContext.Materials.ToList(); // �ndra _dbContext till r�tt instance

        //    return View(materials);
        //}


        //[HttpPost]
        //public IActionResult AddMaterial(Material material)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        // �ndra _dbContext till r�tt instance
        //        _dbContext.Materials.Add(material);
        //        _dbContext.SaveChanges();

        //        return RedirectToAction(nameof(StorageOfMaterials));
        //    }
        //    
        //    return View(material);
        //}



        //[HttpPost]
        //public IActionResult EditMaterial(Material material)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        // �ndra _dbContext till r�tt instance
        //        _dbContext.Materials.Update(material);
        //        _dbContext.SaveChanges();

        //        return RedirectToAction(nameof(StorageOfMaterials));
        //    }
            
        //    return View(material);
        //}



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
