using System;
using System.Collections.Generic;

namespace Tracker.Models
{
  public class Order
  {
    public string Title;
    public string Date;
    public string Details;
    public int Price;
    public static List<Order> _orderInstance = new List<Order> {};

    public Order(string title, string date, string details, int price)
    {
      Title = title; 
      Date = date;
      Details = details;
      Price = 0;
    }
    
  }

}