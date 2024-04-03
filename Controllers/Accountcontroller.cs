using Microsoft.AspNetCore.Mvc;

namespace Hattfabriken.Controllers
{
    public class Accountcontroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
