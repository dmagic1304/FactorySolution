using Microsoft.AspNetCore.Mvc.Rendering;
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
      if (!ModelState.IsValid)
      {
        ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "Name");
        return View(engineer);
      }
      else
      {
        _db.Engineers.Add(engineer);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
    }

    public ActionResult Details (int id)
    {
      Engineer thisEngineer = _db.Engineers.FirstOrDefault( engineer => engineer.EngineerId == id);
      return View(thisEngineer);
    }
    
  }
}