﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CV_Project_Group2.Models;

namespace CV_Project_Group2.Controllers;

    public class UserController : Controller
    {

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
    }

