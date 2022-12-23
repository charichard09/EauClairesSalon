using HairSalon.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;

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

    public async Task<IActionResult> Index(string searchString)
    {
      if (_db.Stylists == null)
      {
          return Problem("Entity set 'MvcMovieContext.Movie'  is null.");
      }

      Stylist stylist = from i in _db.Stylists
                  select i;

      if (!String.IsNullOrEmpty(searchString))
      {
          stylist = stylist.Where(s => s.Name!.Contains(searchString));
      }

      return View(await stylist.ToListAsync());
    }
  }
}