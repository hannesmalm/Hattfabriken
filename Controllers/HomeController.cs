using Microsoft.AspNetCore.Mvc;

namespace Hattfabriken.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
