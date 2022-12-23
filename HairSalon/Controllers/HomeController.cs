using HairSalon.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

using System;

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
      // Perform the search and retrieve the results
      List<Stylist> stylistResults = _db.Stylists.Where(s => s.Name.Contains(query)).ToList();
      List<Client> clientResults = _db.Clients.Where(c => c.Name.Contains(query)).ToList();
      Dictionary<string, object[]> results = new Dictionary<string, object[]>();
      // ViewBag.stylists = stylistResults;
      // ViewBag.clients = clientResults;
      foreach (Stylist stylist in stylistResults)
      {
        Console.WriteLine(stylist.Name);
      }
      foreach (Client client in clientResults)
      {
        Console.WriteLine(client.Name);
      }
      results.Add("stylists", stylistResults.ToArray());
      results.Add("clients", clientResults.ToArray());

      // Return the view with the results
      return View("Index", results);
    }
  }
}