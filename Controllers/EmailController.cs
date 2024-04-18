using System.Diagnostics;
using System.Net.Mail;
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

        [HttpGet]
        public IActionResult OpenEmailClient(string emailAdress)
        {
            string url = $"outlook://search/{emailAdress}";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });

            return Content("E-postklienten öppnad för sökning: " + emailAdress);

        }
    }
}
