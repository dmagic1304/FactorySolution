using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
    public class HomeController : Controller
    { 

      private readonly FactoryContext _db;

      public HomeController(FactoryContext db)
      {        
        _db = db;
      }

      [HttpGet("/")]
      public ActionResult Index()
      {
        List<Engineer> allEngineers = _db.Engineers.ToList();
        ViewBag.AllMachines = _db.Machines.ToList();
        return View(allEngineers);
      }

    }
}