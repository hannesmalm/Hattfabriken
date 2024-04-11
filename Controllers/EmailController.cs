using Microsoft.AspNetCore.Mvc;

namespace Hattfabriken.Controllers
{
    public class EmailController : Controller
    {
        public IActionResult SendAnEmail()
        {
            return View();
        }
    }
}
