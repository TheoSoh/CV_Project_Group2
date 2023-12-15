using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CV_Project_Group2.Models;

namespace CV_Project_Group2.Controllers;


    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

