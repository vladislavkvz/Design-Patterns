namespace Flyweight
{
    using Entities;
    using System;

    class Program
    {
        private static string[] colors = { "Red", "Green", "Blue", "White", "Black" };
   
        static void Main()
        {
            Random rand = new Random();
            for (int i = 0; i < 20; ++i)
            {
                Circle circle = (Circle)ShapeFactory.GetCircle(GetRandomColor(rand));
                circle.SetX(GetRandomX(rand));
                circle.SetY(GetRandomY(rand));
                circle.SetRadius(100);
                circle.Draw();
            }
        }
        private static string GetRandomColor(Random rand)
        {
            return colors[(rand.Next(0,colors.Length))];
        }
        private static int GetRandomX(Random rand)
        {
            return (rand.Next());
        }
        private static int GetRandomY(Random rand)
        {
            return (rand.Next());
        }
    }
}