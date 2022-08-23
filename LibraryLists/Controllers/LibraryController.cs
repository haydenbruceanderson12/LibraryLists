using LibraryLists.Data;
using LibraryLists.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Library obj)

        {
            if (ModelState.IsValid)
            {
                _db.Library.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id==0)
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
        //ERRORS
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Library obj)

        {
            if (ModelState.IsValid)
            {
                _db.Update(obj);
                _db.SaveChanges();
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
        //ERRORS
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Library obj)

        {
            if (ModelState.IsValid)
            {
                _db.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }


    }
}
