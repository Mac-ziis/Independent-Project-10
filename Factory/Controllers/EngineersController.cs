using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;

namespace Factory.Controllers
{
  public class EngineersController : Controller
  {
    private readonly FactoryContext _db;

    public EngineersController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Engineer> model = _db.Engineers.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Engineer engineer)
    {
      _db.Engineers.Add(engineer);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    // public ActionResult Details(int id)
    // {
    //   Category thisCategory = _db.Categories
    //                             .Include(cat => cat.Items)
    //                             .ThenInclude(item => item.JoinEntities)
    //                             .ThenInclude(join => join.Tag)
    //                             .FirstOrDefault(category => category.CategoryId == id);
    //   return View(thisCategory);
    // }

    public ActionResult Edit(int id)
    {
      Engineer thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == id);
      return View(thisEngineer);
    }

    [HttpPost]
    public ActionResult Edit(Engineer engineer)
    {
      _db.Engineers.Update(engineer);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      Engineer thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == id);
      return View(thisEngineer);
    }

    // [HttpPost, ActionName("Delete")]
    // public ActionResult DeleteConfirmed(int id)
    // {
    //   Category thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
    //   _db.Categories.Remove(thisCategory);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    public ActionResult AddTag(int id)
    // {
    //   Item thisItem = _db.Items.FirstOrDefault(items => items.ItemId == id);
    //   ViewBag.TagId = new SelectList(_db.Tags, "TagId", "Title");
    //   return View(thisItem);
    // }

    // [HttpPost]
    // public ActionResult AddTag(Item item, int tagId)
    // {
    //   #nullable enable
    //   ItemTag? joinEntity = _db.ItemTags.FirstOrDefault(join => (join.TagId == tagId && join.ItemId == item.ItemId));
    //   #nullable disable
    //   if (joinEntity == null && tagId != 0)
    //   {
    //     _db.ItemTags.Add(new ItemTag() { TagId = tagId, ItemId = item.ItemId });
    //     _db.SaveChanges();
    //   }
    //   return RedirectToAction("Details", new { id = item.ItemId });
    // }   

    // [HttpPost]
    // public ActionResult DeleteJoin(int joinId)
    // {
    //   ItemTag joinEntry = _db.ItemTags.FirstOrDefault(entry => entry.ItemTagId == joinId);
    //   _db.ItemTags.Remove(joinEntry);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // } 
  }
}