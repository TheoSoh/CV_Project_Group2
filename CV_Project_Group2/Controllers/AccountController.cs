﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CV_Project_Group2.Models;
using Microsoft.AspNetCore.Identity;

namespace CV_Project_Group2.Controllers;

    public class AccountController : Controller
    {

        private readonly ILogger<AccountController> _logger;
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;

        public AccountController(ILogger<AccountController> logger, UserManager<User> userMngr, SignInManager<User> signInMngr)
        {
            _logger = logger;
            _userManager = userMngr;
            _signInManager = signInMngr;
        }

        [HttpGet] 
        public IActionResult Login()
        {
            LoginViewModel loginViewModel = new LoginViewModel();
            return View(loginViewModel);

        }

        [HttpGet]

        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel) {

            if (ModelState.IsValid) {

                User user = new User();
                user.UserName = registerViewModel.UserName;
                user.FirstName = registerViewModel.FirstName;
                user.LastName = registerViewModel.LastName;
                user.Email = registerViewModel.Email;
                user.PhoneNumber = registerViewModel.PhoneNumber;
                user.Password = registerViewModel.Password;
            

                var result = await _userManager.CreateAsync(user, registerViewModel.Password);

                if (result.Succeeded)
                {

                    await _signInManager.SignInAsync(user, isPersistent: true); // skapar en cookie som tillåter användaren att vara inloggad i flera sessioner samtidigt, även om webbläsaren stängs ner
                    return RedirectToAction("Login", "Account");

                }

                foreach (var error in result.Errors)
                {
                ModelState.AddModelError(string.Empty, error.Description);
                }
        }

            return View(registerViewModel);
        }

        public IActionResult UserProfile() 
        {
        var user = new User
        {
            UserName = "john_doe",
            FirstName = "John",
            LastName = "Doe",
            Email = "john@example.com"
        };

        return View("UserProfile", user); 
    
        }
}



