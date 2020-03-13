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
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.RetrieveList();
      return View(allVendors);
    }
    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int Id)
    {
      Vendor findVendor = Vendor.Find(Id);
      return View(findVendor);
    }
    [HttpGet("/orders")]
    public ActionResult Orders()
    {
      return View();
    }
    [HttpPost("/vendors/{id}")]
    public ActionResult Create(string title, string date, string details, int price)
    {
      Order newOrder = new Order(title, date, details, price);
      return RedirectToAction("OrdersIndex", newOrder);
    }
    // [HttpGet("/vendors/{id}")]
    // public ActionResult OrdersIndex()
    // {
    //   List<Order> allOrders = Order.OrderList();
    //   return View(allOrders);
    // }
  }
}