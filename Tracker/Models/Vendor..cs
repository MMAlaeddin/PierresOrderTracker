using System;
using System.Collections.Generic;

namespace Tracker.Models
{
  public class Vendor
  {
    public string Business { get; set; }
    public string Buyer { get; set; }
    public string Description { get; set; }
    public int Id { get; set; }
    private static List<Vendor> _instances = new List<Vendor> {};
    public List<Order> AllOrders = new List<Order> {};

    public Vendor(string business, string buyer, string description)
    {
      Business = business;
      Buyer = buyer;
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static List<Vendor> RetrieveList()
    {
      return _instances;
    }
    public static Vendor Find(int searchId)
    {
      return _instances[searchId - 1];
    }
    public void VendorsOrder(Order order)
    {
      AllOrders.Add(order);
    }
  }
}