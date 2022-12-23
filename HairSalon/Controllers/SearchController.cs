using HairSalon.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


namespace HairSalon.Controllers
{
  public class SearchController : Controller
  {
    private readonly HairSalonContext _db;

    public SearchController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Search(string query)
    {
      // Perform the search and retrieve the results
      List<Stylist> results = _db.Stylists.Where(s => s.Name.Contains(query)).ToList();

      // Return the view with the results
      
      return View(results);
    }
  }
}