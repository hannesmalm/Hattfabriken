using Microsoft.AspNetCore.Mvc;

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
