using Microsoft.AspNetCore.Mvc;
using Tracker.Models;
using System.Collections.Generic;

namespace Tracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpPost("/vendors")]
    public ActionResult Create(string business, string buyer, string description)
    {
      Vendor newVendor = new Vendor(business, buyer, description);
      return RedirectToAction ("Index", newVendor);
    }
    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpGet("/vendors")]
    public ActionResult Show()
    {
      List<Vendor> allVendors = Vendor.RetrieveList();
      return View(allVendors);
    }
  }
}