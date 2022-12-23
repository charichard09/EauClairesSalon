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
      List<Stylist> stylistResults = _db.Stylists.Where(s => s.Name.Contains(query)).ToList();
      List<Client> clientResults = _db.Clients.Where(c => c.Name.Contains(query)).ToList();
      Dictionary<string, object> results = new Dictionary<string, object>();

      results.Add("stylists", stylistResults);
      results.Add("clients", clientResults);

      return View(results);
    }
  }
}