using Microsoft.AspNetCore.Mvc;

namespace LibraryLists.Controllers
{
    public class FavoritesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
