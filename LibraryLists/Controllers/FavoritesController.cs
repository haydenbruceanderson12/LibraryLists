using LibraryLists.Data;
using LibraryLists.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryLists.Controllers
{
    public class FavoritesController : Controller
    {

        private readonly AppDbContext _db;

        public FavoritesController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Favorites> obj = _db.Favorites;
            _db.SaveChanges();
            return View(obj);
        }
    }
}
