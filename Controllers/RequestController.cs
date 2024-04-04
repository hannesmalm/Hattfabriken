using Microsoft.AspNetCore.Mvc;

namespace Hattfabriken.Controllers
{

    public class RequestController : Controller
    {

        public IActionResult NewRequest()
        {
            return View();
        }

        public IActionResult RequestThru()
        {

            return View();
        }

    }
}
