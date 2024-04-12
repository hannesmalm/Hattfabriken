using System.Net.Mail;
using Hattfabriken.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Options;
using MimeKit;

namespace Hattfabriken.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MailController : ControllerBase
    {
        private readonly IMailService _mailService;
        //injecting the IMailService into the constructor
        public MailController(IMailService _MailService)
        {
            _mailService = _MailService;
        }
        [HttpPost]
        [Route("SendMail")]
        public IActionResult SendMail([FromBody] MailData mailData)
        {
            bool isSent = _mailService.SendMail(mailData);

            if (isSent)
            {
                return Ok("Email sent successfully");
            }
            else
            {
                return BadRequest("Failed to send email");
            }
        }
        


    }
}

   
