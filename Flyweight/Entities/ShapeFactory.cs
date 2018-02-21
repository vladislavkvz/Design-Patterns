namespace Flyweight.Entities
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShapeFactory
    {
        private static Dictionary<string,IShape> circleDictionary = new Dictionary<string, IShape>();

        public static IShape GetCircle(string color)
        {
            Circle circle = null;

            if (!circleDictionary.ContainsKey(color))
            {
                circle = new Circle(color);
                circleDictionary.Add(color, circle);
                Console.WriteLine("Creating circle of color : " + color);
            }
            else
            {
                circle = (Circle)circleDictionary[color];
            }
            return circle;
        }
    }
}
