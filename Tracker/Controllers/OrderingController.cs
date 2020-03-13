using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Tracker.Models;

namespace Tracker.Controllers
{
  public class OrderingController : Controller
  {

    [HttpGet("/orders")]
    public ActionResult Index()
    {
      List<Order> allOrders = Order.AddOrder();
      return View(allOrders);
    }
    [HttpGet("/orders/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/orders")]
    public ActionResult Create(string orderTitle)
    {
    Category newOrder = new Category(orderTitle);
    return RedirectToAction("Index");
    }
  }
}