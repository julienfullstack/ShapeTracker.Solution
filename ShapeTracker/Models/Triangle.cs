using System;

namespace ShapeTracker
{
  class Program
  {
    static void Main()
    {
      ShapeTracker.Models.Triangle testTriangle = new ShapeTracker.Models.Triangle();
      Console.WriteLine(testTriangle.GetType());
    }
  }
}