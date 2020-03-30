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
      return RedirectToAction ("Index");
    }
    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.RetrieveList();
      return View(allVendors);
    }
    [HttpGet("/vendors/{Id}")]
    public ActionResult Show(int Id)
    {
      Vendor findVendor = Vendor.Find(Id);
      return View(findVendor);
    }
    [HttpGet("/vendors/{Id}/orders/new")]
    public ActionResult CreateOrder(int Id)
    {
      Vendor myVendor = Vendor.Find(Id);
      return View(myVendor);
    }
    [HttpPost("vendors/{Id}/orders")]
    public ActionResult Create(string title, string date, string details, int price, int Id)
    {
      Order buildOrder = new Order(title, date, details, price);
      Vendor myVendor = Vendor.Find(Id);
      myVendor.VendorsOrder(buildOrder);
      return RedirectToAction("Show");
    }
  }
}
