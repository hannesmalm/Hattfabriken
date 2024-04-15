using Microsoft.AspNetCore.Mvc;
using Hattfabriken.Models.Viewmodels;

namespace Hattfabriken.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Home/AdminPage.cshtml");
        }


    }
}
