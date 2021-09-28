using System.Collections.Generic;
using System;

namespace CarDealership.Models 
{
  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    private static List<Car> _make = new List<Car> {};

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      _make.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _make;
    }

    public static void ClearAll()
    {
      _make.Clear();
    }
  }
}
