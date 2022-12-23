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

    // public ActionResult Search(string query)
    // {
    //   // Perform the search and retrieve the results
    //   List<Stylist> results = _db.Stylists.Where(s => s.Name.Contains(query)).ToList();

    //   // Return the view with the results
      
    //   return View("Index", results);
    // }
  }
}