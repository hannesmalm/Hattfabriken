using Hattfabriken.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hattfabriken.Models.ViewModels;

namespace Hattfabriken.Controllers
{
    public class SpecialEffectsController : Controller
    {
        private readonly HatDbContext _context;

        public SpecialEffectsController(HatDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var specialEffects = await _context.SpecialEffects.ToListAsync();
            return View("SpecialEffects", specialEffects);
        }

        [HttpGet]
        public IActionResult AddSpecialEffects()
        {
            SpecialEffectsViewModel specialEffectsViewModel = new SpecialEffectsViewModel();   
            return View(specialEffectsViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddSpecialEffects(SpecialEffectsViewModel specialEffectsViewModel) { 

            if(ModelState.IsValid)

            {
                SpecialEffects specialEffects = new SpecialEffects
                {
                    SpecialEffectName = specialEffectsViewModel.SpecialEffectName,
                    Price = specialEffectsViewModel.Price
                };

                _context.Add(specialEffects);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return View(specialEffectsViewModel);
            
        }
    }
}
