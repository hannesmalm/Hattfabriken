using Microsoft.AspNetCore.Mvc;
using Hattfabriken.Models.Viewmodels;
using Microsoft.AspNetCore.Identity;

namespace Hattfabriken.Controllers
{
    public class AccountController : Controller
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;

        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(CreateAccountViewModel model)
        {

            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                {

                    UserName = model.Username

                };


                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {

                    return RedirectToAction("Index", "Home");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);

                }

            }

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteAccount()
        {

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {

                return RedirectToAction("Index", "Home");
             
             }

            var result = await _userManager.DeleteAsync(user);
            if (result.Succeeded) 
            {
                await _signInManager.SignOutAsync();
                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Index", "Home"); // Tillbaka till startsidan vid misslyckad radering.
        }

    }





}



