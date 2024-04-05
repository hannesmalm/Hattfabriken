using Hattfabriken.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Hattfabriken.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GoToAdminPage()
        {
            // Anv�nd RedirectToAction f�r att dirigera till AdminController och dess Index-�tg�rd
            return RedirectToAction();
        }

    }
}
