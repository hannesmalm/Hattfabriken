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
            
            if (requestList.Count == 0)
            {
                requestList = new List<Request>();
            }
            
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
            Request request = _context.Requests.SingleOrDefault(r => r.Id == requestId);

            if (request == null)
            {
                return NotFound();
            }

            request.Status = "Accepted";
            _context.Update(request);
            _context.SaveChanges();

            // GÅ VIDARE TILL SKAPA OFFERT (CreateOffert())
            return RedirectToAction("Create", "Offer", new { requestId = requestId });
        }

        [HttpPost]
        public IActionResult DeclineRequest(int requestId)
        {
            var request = _context.Requests.SingleOrDefault(r => r.Id == requestId);
            if (request == null)
            {
                return NotFound();
            }

            request.Status = "Declined";
            _context.Update(request);
            _context.SaveChanges();

            
            return RedirectToAction("AllRequests");
        }

        public IActionResult RequestSuccess()
        {
            return View();
        }

    }
}
