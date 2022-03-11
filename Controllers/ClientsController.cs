using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;

    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }

    // public ActionResult Index()
    // {
    //   List<Client> model = _db.Clients.Include(c =>  c.Stylists).ToList();
    //   // List<Client> model = _db.Clients.ToList();
    //   ViewBag.PageTitle = "View All Clients";
    //   return View(model);
    // }

    public ActionResult Create(int id)
    {
      ViewBag.StylistId = id;
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client client)
    {
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index", "Stylists"); 
    }

    public ActionResult Details(int id)
    {
      Client thisClient = _db.Clients.FirstOrDefault(c => c.ClientId == id);
      return View(thisClient);
    }
  }
}