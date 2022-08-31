

//GET ACTION


//Creating EDIT View for Not found - If Id doesn't exist.

/*
 public NotFoundResult Edit1(int? id)
{
    if (id == null || id == 0)
    {
        return NotFound();
    }
}

//Creating EDIT view for Result found - If Id does exist.

public ViewResult Edit2(int? id)
{
    if (id == null || id == 0)
    {
        return null;
    }
    var categoryFromDb = _db.Library.Find(id);
    return View(categoryFromDb);
}


*/