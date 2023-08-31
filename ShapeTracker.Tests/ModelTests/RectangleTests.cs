// using System.Collections.Generic; // because we use a list in our file

// namespace ShapeTracker.Models //same namespace as Triangle.cs
// {
//   public class Rectangle // define our Rectangle class
//   {
//     public int Side1 { get; set; } // auto implemented properties  --special note: you will use this method in your CR, I would suggest you get used to this syntax, unbless you feel that your app will need custom getters and setters
//     public int Side2 { get; set; }
//     public int Side3 { get; set; }
//     public int Side4 { get; set; }
//     private static List<Rectangle> _instances = new List<Rectangle> { }; // this list acts as a sort of proxy database to store all the Rectangles we create
    
//     public Rectangle(int length1, int length2, int length3, int length4) // our Rectangle constructor notice that is accepts 4 parameters and then adds 'this' - the Rectangle we are constructing to out _instances "database"
//     {
//       Side1 = length1;
//       Side2 = length2;
//       Side3 = length3;
//       Side4 = length4;
//       _instances.Add(this);
//     }

//     // Rectangle class methods are very similar to what we have in the Triangle class (Triangle.cs)

//     /// <summary>
//     /// Checks whether or not object sides would create a valid rectangle
//     /// </summary>
//     /// <returns>the coolest string</returns>
//     public string CheckType() 
//     {
//       if (((Side1 == Side2) && (Side3 == Side4)) || ((Side1 == Side3) && (Side2 == Side4)) || ((Side1 == Side4) && (Side2 == Side3)))
//       {
//         return "this is a rectangle";
//       }
//       else
//       {
//         return "not a rectangle";
//       }
//     }

//     public static List<Rectangle> GetAll()
//     {
//       return _instances;
//     }
// /// <summary>
// /// Clears all instances of object
// /// </summary>
//     public static void ClearAll()
//     {
//       _instances.Clear();
//     }
//   }
// }