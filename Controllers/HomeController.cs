using Hattfabriken.Models;
using Hattfabriken.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Hattfabriken.Controllers
{
    public class HomeController : Controller
    {
        private readonly HatDbContext _dbContext;
        private readonly IImageService _imageService;
        public HomeController(HatDbContext dbContext, IImageService imageService)
        {
            _dbContext = dbContext;
            _imageService = imageService;

        }
        public IActionResult Index()
        {
            var existingHats = _dbContext.Hats.ToList();
            return View(existingHats);
        }

        public IActionResult GoToAdminPage()
        {
            return RedirectToAction();
        }

        

    }
}
