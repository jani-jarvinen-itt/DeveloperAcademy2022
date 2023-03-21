using AspNetCosmosDbDemo.Database;
using AspNetCosmosDbDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspNetCosmosDbDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            // read the customer from Cosmos DB
            DatabaseAccess database = new();
            Customer c = await database.ReadCustomer("1234");

            return View(c);
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