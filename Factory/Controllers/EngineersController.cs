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
      ViewBag.MachineId = new SelectList(_db.Machines, "MachineId", "Name");
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
      Engineer thisEngineer = _db.Engineers
                                    .Include(engineer => engineer.JointEntities)
                                    .ThenInclude(join => join.Machine)
                                    .FirstOrDefault( engineer => engineer.EngineerId == id);
      return View(thisEngineer);
    }
    
    public ActionResult AddMachine(int id)
    {
      Engineer thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == id);
      ViewBag.MachineId = new SelectList(_db.Machines, "MachineId", "Name");
      return View(thisEngineer);
    }

    [HttpPost]
    public ActionResult AddMachine(Engineer engineer, int machineId)
    {      
      #nullable enable
      EngineerMachine? joinEntity = _db.EngineerMachine.FirstOrDefault(join => (join.MachineId == machineId && join.EngineerId == engineer.EngineerId));
      #nullable disable
      if (joinEntity == null && machineId != 0)
      {
        _db.EngineerMachines.Add(new EngineerMachine() { MachineId = machineId, EngineerId = engineer.EngineerId });
        _db.SaveChanges();        
      }
      
      return RedirectToAction("Details", new { id = engineer.EngineerId });
    }   
  }
}