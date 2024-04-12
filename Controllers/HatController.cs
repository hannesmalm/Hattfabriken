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

        [HttpPost]
        public IActionResult AddHat(Hatt hat)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Hattar.Add(hat);
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
