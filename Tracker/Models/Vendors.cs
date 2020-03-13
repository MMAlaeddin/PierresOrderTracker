using System;
using System.Collections.Generic;

namespace Tracker.Models
{
  public class Vendor
  {
    public string Business { get; set; }
    public string Buyer { get; set; }
    public string Description { get; set; }
    private static List<Vendor> _instances = new List<Vendor> {};

    public Vendor(string business, string buyer, string description)
    {
      Business = business;
      Buyer = buyer;
      Description = description;
      _instances.Add(this);
    }
    public static List<Vendor> RetrieveList()
    {
      return _instances;
    }
  }
}