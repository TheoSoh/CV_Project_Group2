using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CV_Project_Group2.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

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

        [HttpPost]

        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {

            if (ModelState.IsValid)
            {

                var result = await _signInManager.PasswordSignInAsync(loginViewModel.UserName, loginViewModel.Password, 
                                                 isPersistent:loginViewModel.RememberMe, lockoutOnFailure: false);

                if (result.Succeeded)
                {

                    return RedirectToAction("Index", "Home");
    
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Det gick inte att logga in");
                    return View(loginViewModel);

                }

            }

        return View(loginViewModel);
        }

        [HttpPost]

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index");

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
                user.PasswordHash = registerViewModel.Password;
            

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



