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
        public IActionResult LogIn()
        {
            LoginViewModel loginViewModel = new LoginViewModel();
            return View(loginViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(
                    loginViewModel.UserName,
                    loginViewModel.Password,
                    isPersistent: loginViewModel.RememberMe,
                    lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    // Flytta logiken för att hämta användaren och användarprofilen här
                    var currentUser = await _userManager.FindByNameAsync(loginViewModel.UserName);
                    if (currentUser != null)
                    {
                        //  redirect to admin page 
                        return RedirectToAction("AdminPage", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Wrong Username or Password");
                }
            }
            return View(loginViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                if (user == null)
                {
                    // Hantera fallet när användaren inte hittas
                    return RedirectToAction("LogIn", "Account");
                }

                var changePasswordResult = await _userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);
                if (!changePasswordResult.Succeeded)
                {
                    foreach (var error in changePasswordResult.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    return View();
                }

                await _signInManager.RefreshSignInAsync(user);
                return RedirectToAction("AdminPage", "Home");
            }
            return View(model);
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

                    return RedirectToAction("AdminPage", "Home");
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

                return RedirectToAction("AdminPage", "Home");
             
             }

            var result = await _userManager.DeleteAsync(user);
            if (result.Succeeded) 
            {
                await _signInManager.SignOutAsync();
                return RedirectToAction("AdminPage", "Home");
            }

            return RedirectToAction("AdminPage", "Home");
        }

    }





}



