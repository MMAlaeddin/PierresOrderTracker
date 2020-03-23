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

    public Order (string title, string date, string details, int price)
    {
      Title = title;
      Date = date; 
      Details = details; 
      Price = price; 
      _orderInstance.Add(this);
    }
    // public static List<Order> OrderList()
    // {
    //   return _orderInstance;
    // }
  }
}