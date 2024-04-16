using Microsoft.AspNetCore.Mvc;

namespace Hattfabriken.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Orders()
        {
            return View();
        }
    }
}
