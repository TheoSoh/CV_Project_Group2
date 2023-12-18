using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CV_Project_Group2.Models;
using Microsoft.AspNetCore.Authorization;

namespace CV_Project_Group2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    //[Authorize]
    public IActionResult Index()
    {
        return View("Index");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

