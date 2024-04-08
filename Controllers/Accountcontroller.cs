using Microsoft.AspNetCore.Mvc;
using Hattfabriken.Models.Viewmodels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Hattfabriken.Models;

namespace Hattfabriken.Controllers
{
    public class AccountController : Controller
    {

        private UserManager<User> userManager;
        private SignInManager<User> signInManager;
        private readonly HatDbContext dbContext;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, HatDbContext dbContext)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.dbContext = dbContext;
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
                var result = await signInManager.PasswordSignInAsync(
                    loginViewModel.UserName,
                    loginViewModel.Password,
                    isPersistent: loginViewModel.RememberMe,
                    lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    // Flytta logiken för att hämta användaren och användarprofilen här
                    var currentUser = await userManager.FindByNameAsync(loginViewModel.UserName);
                    if (currentUser != null)
                    {
                        //  redirect to admin page 
                        return RedirectToAction("Index", "Admin");
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
            await signInManager.SignOutAsync();
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
                var user = await userManager.GetUserAsync(User);
                if (user == null)
                {
                    // Hantera fallet när användaren inte hittas
                    return RedirectToAction("LogIn", "Account");
                }

                var changePasswordResult = await userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);
                if (!changePasswordResult.Succeeded)
                {
                    foreach (var error in changePasswordResult.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    return View();
                }

                await signInManager.RefreshSignInAsync(user);
                return RedirectToAction("AdminPage", "Home");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult CreateAccount()
        {
            CreateAccountViewModel createAccountViewModel = new CreateAccountViewModel();
            return View(createAccountViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAccount(CreateAccountViewModel model)
        {

            if (ModelState.IsValid)
            {
                User newUser = new User
                {

                    UserName = model.UserName

                };


                var result = await userManager.CreateAsync(newUser, model.Password);

                if (result.Succeeded)
                {

                    return RedirectToAction("Index", "Admin");
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

            var user = await userManager.GetUserAsync(User);
            if (user == null)
            {

                return RedirectToAction("AdminPage", "Home");
             
             }

            var result = await userManager.DeleteAsync(user);
            if (result.Succeeded) 
            {
                await signInManager.SignOutAsync();
                return RedirectToAction("AdminPage", "Home");
            }

            return RedirectToAction("AdminPage", "Home");
        }

    }





}



