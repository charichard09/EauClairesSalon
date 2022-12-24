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
      List<Client> clientResults = _db.Clients.Where(c => c.Name.Contains(query)).ToList();
      Dictionary<string, object[]> results = new Dictionary<string, object[]>();

      if (stylistResults == null)
      {
        stylistResults = new List<Stylist>() { "No Match Found" };
      }
      if (clientResults == null)
      {
        clientResults = new List<Client>() { "No Match Found" };
      }
      results.Add("stylists",stylistResults);
      results.Add("clients", clientResults);

      return View(results);
    }
  }
}