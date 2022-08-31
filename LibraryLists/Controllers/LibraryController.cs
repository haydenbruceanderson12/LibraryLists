using LibraryLists.Data;
using LibraryLists.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LibraryLists.Controllers
{
    public class LibraryController : Controller
    {
        private readonly AppDbContext _db;

        public LibraryController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Library> ObjList = _db.Library;
            return View(ObjList);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        //Action MUST be explicidly defined.
        [HttpPost]
        public IActionResult Create(Library obj)

        {
            if (ModelState.IsValid)
            {
                _db.Library.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Book Created Successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }


        //GET
        // IActionResult allowing more than one return type.
        // NotFoundResult.

        public IActionResult Edit(int ? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDb = _db.Library.Find(id);
            return View(categoryFromDb);
        }

        //POST
        //ADDITIONAL _db.Update(obj);

        [HttpPost]        
        public IActionResult Edit(Library obj)

        {
            if (ModelState.IsValid)
            {
                _db.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Book Updated Successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var categoryFromDb = _db.Library.Find(id);
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Library obj)

        {
            if (ModelState.IsValid)
            {
                _db.Remove(obj);
                _db.SaveChanges();
                TempData["success"] = "Book Deleted Successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }


    

    //GET
    public IActionResult Add(int ? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }

        var categoryFromDb = _db.Library.Find(id);
        if (categoryFromDb == null)
        {
            return NotFound();
        }
        return View(categoryFromDb);
    }

     //POST
     // Redirecting to The Favorites Controller.
     // SqlException: Cannot insert explicit value for identity column in table 'Library' when IDENTITY_INSERT is set to OFF.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Add(Favorites obj)

    {
        if (ModelState.IsValid)
        {
                _db.Favorites.Add(obj);
               TempData["success"] = "Book Added to Favorites";
              return RedirectToAction("Index", "Favorites");
        }
        return View(obj);
    }

}
}
