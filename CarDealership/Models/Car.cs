using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    public string Make { get; set; }
    public string Model { get; set; }
    public string Year { get; set; }
    public string Color { get; set; }
    private static List<Car> _instances = new List<Car> { };

    public Car(string make, string model, string year, string color)
    {
      Make = make;
      Model = model;
      Year = year;
      Color = color;

      _instances.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
