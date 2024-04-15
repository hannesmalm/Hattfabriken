using Hattfabriken.Models;
using Hattfabriken.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hattfabriken.Controllers
{
    public class RequestController : Controller
    {
        private readonly HatDbContext _context;

        public RequestController(HatDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult NewRequest()
        {
            var materials = _context.Materials.ToList();
            ViewBag.Materials = materials; // Send materials to the view as ViewBag
            RequestViewModel requestViewModel = new RequestViewModel();
            return View(requestViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> NewRequest(RequestViewModel requestViewModel)
        {
            if (ModelState.IsValid)
            {
                var materialName = requestViewModel.Material.Split('-')[0].Trim();
                var material = await _context.Materials.FirstOrDefaultAsync(m => m.MaterialName == materialName);

                if (material != null)
                {
                    Request request = new Request
                    {
                        // Map properties from requestViewModel to Request entity
                    };

                    // Calculate total price
                    request.Price = material.Price + requestViewModel.HatTypePrice + requestViewModel.SpecialEffectsPrice;

                    // Add the request to the database
                    _context.Add(request);
                    await _context.SaveChangesAsync();

                    return RedirectToAction("RequestSuccess", "Request");
                }
            }

            return View(requestViewModel);
        }

        public IActionResult RequestSuccess()
        {
            return View();
        }
    }
}
