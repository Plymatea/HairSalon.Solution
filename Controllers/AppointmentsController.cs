// using Microsoft.AspNetCore.Mvc.Rendering;
// using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
// using System.Collections.Generic;
// using System.Linq;

namespace HairSalon.Controllers
{
  public class AppointmentsController : Controller
  {
    private readonly HairSalonContext _db;

    public AppointmentsController(HairSalonContext db)
    {
      _db = db;
    }
    
    public ActionResult Create(int stylistId, int clientId, string stylistName, string clientName)
    {
      ViewBag.PageTitle = "Eau Claire's: New Appointment";
      ViewBag.StylistId = stylistId;
      ViewBag.ClientId = clientId;
      ViewBag.ClientName = clientName;
      ViewBag.StylistName = stylistName;
      return View();
    }

    [HttpPost]
    public ActionResult Create(Appointment appointment)
    {
      _db.Appointments.Add(appointment);
      _db.SaveChanges();
      return RedirectToAction("Index", "Stylists"); 
    }
  }
}