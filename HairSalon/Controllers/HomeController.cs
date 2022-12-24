using HairSalon.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


namespace HairSalon.Controllers
{
  public class HomeController : Controller
  {
    private readonly HairSalonContext _db;

    public HomeController(HairSalonContext db)
    {
      _db = db;
    }

    [Route("/")]
    public ActionResult Index() 
    {
      return View();
    }

    public ActionResult Search(string query)
    {
      List<Stylist> stylistResults = _db.Stylists.Where(s => s.Name.Contains(query)).ToList();

      return View(stylistResults);
    }
  }
}