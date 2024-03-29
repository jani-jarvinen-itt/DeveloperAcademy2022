﻿using AspNetMvcFormSubmit.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspNetMvcFormSubmit.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FormDemo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FormDemo(FormDemoData data)
        {
            string csvPath = "C:\\DeveloperAcademy\\Code\\DotNet\\Users.csv";
            string newLine = $"{data.UserName},{data.UserEmail}\r\n";
            System.IO.File.AppendAllText(csvPath, newLine);

            return View("FormDemoThankYou", data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}