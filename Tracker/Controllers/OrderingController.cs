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
      List<Order> allCategories = Category.GetAll();
      return View(allCategories);
    }
    [HttpGet("/categories/new")]
    public ActionResult New()
    {
      return View();
    }
  }
}