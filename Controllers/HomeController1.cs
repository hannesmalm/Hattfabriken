using Microsoft.AspNetCore.Mvc;

namespace Hattfabriken.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
