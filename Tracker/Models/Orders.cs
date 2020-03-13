using System;
using System.Collections.Generic;

namespace Tracker.Models
{
  public class Order
  {
    private static List<Order> _orderInstance = new List<Order> {};
    public string Title { get; set; }
    public string Date { get; set; }
    public string Details { get; set; }
    public int Price { get; set; }
    public int AnId { get; }
    public List<Order> Orders { get; set; }

    public Order (string orderTitle)
    {
      Title = orderTitle;
      _orderInstance.Add(this)
      AnId = _orderInstance.Count;
      Orders = new List<Order>
    }
    public static List<Order> OrderList()
    {
      return _orderInstance;
    }

  }

}