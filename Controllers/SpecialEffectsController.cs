using Hattfabriken.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hattfabriken.Controllers
{
    public class SpecialEffectsController : Controller
    {
        private readonly HatDbContext _context;

        public SpecialEffectsController(HatDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View("SpecialEffects");
        }

        [HttpGet]
        public IActionResult CreateSpecial()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateSpecial(SpecialEffects specialEffect)
        {

            if(ModelState.IsValid)
            {
                _context.Add(specialEffect);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(specialEffect);
            
        }
    }
}
