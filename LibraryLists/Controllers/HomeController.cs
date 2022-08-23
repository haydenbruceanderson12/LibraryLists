using LibraryLists.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LibraryLists.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // IActionResult allows many return types rather than just a single return type.
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Library()
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