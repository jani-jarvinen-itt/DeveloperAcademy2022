using AspNetMvcUserTable.Models;
using AspNetMvcUserTable.Utilities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspNetMvcUserTable.Controllers
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

        public string Hello()
        {
            return $"Hello World!";
        }

        public IActionResult UserList()
        {
            CsvParser parser = new();
            List<UserDetails> users = parser.ReadUserList();

            return View(users);
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