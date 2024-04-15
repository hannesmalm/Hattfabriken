using Hattfabriken.Models;
using Microsoft.AspNetCore.Mvc;
using Hattfabriken.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using Hattfabriken.Models.Interfaces;
using MailKit;


namespace Hattfabriken.Controllers
{

    public class RequestController : Controller
    {
        private readonly HatDbContext _context;
        private readonly IImageService _imageService;
        private readonly Models.Interfaces.IMailService _mailService;
       

        public RequestController(HatDbContext context, IImageService imageService)
        {
            _context = context;
            _imageService = imageService;
            _mailService = this._mailService;
        }


        [HttpGet]
        public IActionResult NewRequest()
        {
            RequestViewModel requestviewModel = new RequestViewModel();
            return View(requestviewModel);
        }

        [HttpPost]
        public async Task<IActionResult> NewRequest(RequestViewModel requestViewModel)
        {
            if (ModelState.IsValid)
            {
                Request request = new Request
                {
                    Commentary = requestViewModel.Commentary,
                    Material = requestViewModel.Material,
                    Measurement = requestViewModel.Measurement,
                    Height = requestViewModel.Height,
                    HatId = requestViewModel.HatId,
                    Country = requestViewModel.Country,
                    Adress = requestViewModel.Adress,
                    PostalCode = requestViewModel.PostalCode,
                    Email = requestViewModel.Email,
                    PhoneNumber = requestViewModel.PhoneNumber,
                    Name = requestViewModel.Name,
                    Date = DateTime.Now,
                    DeliveryOrPickup = requestViewModel.DeliveryOrPickup,
                    Urgent = requestViewModel.Urgent
                };

                if (requestViewModel.RequestImage != null && requestViewModel.RequestImage.Length > 0)
                {
                    var image = new Image
                    {
                        Data = _imageService.ConvertToByteArray(requestViewModel.RequestImage)
                    };

                    _context.Images.Add(image);
                    await _context.SaveChangesAsync();

                    request.RequestImage = image.Data;

                    Console.WriteLine(image.Data);
                }

                if (requestViewModel.SelectedSpecialEffekter != null && requestViewModel.SelectedSpecialEffekter.Any())
                {
                    request.SpecialEffects = new List<string>(requestViewModel.SelectedSpecialEffekter);
                }
                else
                {
                    request.SpecialEffects = new List<string>(); // Tom lista om ingen special effekt är vald
                }

                _context.Add(request);
                await _context.SaveChangesAsync();

                return RedirectToAction("RequestSuccess", "Request");
            }

            foreach (var key in ModelState.Keys)
            {
                foreach (var error in ModelState[key].Errors)
                {
                    Console.WriteLine($"Fält: {key}, Fel: {error.ErrorMessage}");
                }
            }

            return View(requestViewModel);
        }

        public IActionResult AllRequests()
        {
            var requestList = _context.Requests.ToList(); // Hämta alla Förfrågningar från databasen
            return View(requestList);
        }

        [HttpGet]
        public IActionResult Request(int requestId)
        {
            Console.WriteLine("Metod anropad med requestId: " + requestId);

            Request request = _context.Requests.SingleOrDefault(r => r.Id == requestId);
            return View("Request", request);
        }

        [HttpPost]
        public IActionResult AcceptRequest(int requestId)
        {
            var request = _context.Requests.SingleOrDefault(r => r.Id == requestId);
            if (request == null)
            {
                return NotFound(); // Handle if request is not found
            }

            request.Status = "Accepted";
            _context.Update(request);
            _context.SaveChanges();

            // Assuming you have the necessary data, construct the email
            var mailData = new MailData
            {
                EmailToID = request.Email, // Use customer email
                EmailToName = request.Name, // Use customer name
                EmailSubject = "Request Accepted",
                EmailBody = "Dear Customer, Your request has been accepted." // Customize the message
            };

            if (_mailService.SendMail(mailData))
            {
                // Redirect to EmailController's SendAnEmail action
                return RedirectToAction("SendAnEmail", "Email", mailData);
            }
            else
            {
                // Handle email sending failure
                TempData["ErrorMessage"] = "Failed to send email.";
                return RedirectToAction("Request", new { requestId = requestId });
            }
        }

        [HttpPost]
        public IActionResult DeclineRequest(int requestId)
        {
            var request = _context.Requests.SingleOrDefault(r => r.Id == requestId);
            if (request == null)
            {
                return NotFound(); // Handle if request is not found
            }

            request.Status = "Declined";
            _context.Update(request);
            _context.SaveChanges();

            // Assuming you have the necessary data, construct the email
            var mailData = new MailData
            {
                EmailToID = request.Email, // Use customer email
                EmailToName = request.Name, // Use customer name
                EmailSubject = "Request Declined",
                EmailBody = "Dear Customer, Your request has been declined." // Customize the message
            };

            if (_mailService.SendMail(mailData))
            {
                // Redirect to EmailController's SendAnEmail action
                return RedirectToAction("SendAnEmail", "Email", mailData);
            }
            else
            {
                // Handle email sending failure
                TempData["ErrorMessage"] = "Failed to send email.";
                return RedirectToAction("Request", new { requestId = requestId });
            }
        }

        public IActionResult RequestSuccess()
        {
            return View();
        }

    }
}
