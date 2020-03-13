using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Tracker.Models;

namespace Tracker.Controllers
{
  public class OrderingController : Controller
  {
    [HttpGet("/orders/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/orders")]
    public ActionResult Create(string orderTitle)
    {
    Order newOrder = new Order(orderTitle);
    return RedirectToAction("Index");
    }
  }
}