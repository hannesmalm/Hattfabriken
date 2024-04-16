using Hattfabriken.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hattfabriken.Controllers
{
    public class EmailController : Controller
    {
        [HttpGet]
        public IActionResult SendAnEmail(MailData mailData)
        {
            return View(mailData);
        }
    }
}
