namespace Bridge.Entities
{
    using Interfaces;
    using System;


    public class Circle : Shape
    {
        private int x, y, radius;
        public Circle(int x, int y, int radius, IDraw draw)
            :base(draw)
        {
            this.x = x; this.y = y; this.radius = radius;
        }

        public override void Draw()
        {
            draw.drawCircle(radius, x, y);
        }
    }

    public class RedCircle : IDraw
    {
        public void drawCircle(int radius, int x, int y)
        {
            Console.WriteLine("Drawing Circle[ color: red, radius: " + radius + ", x: " + x + ", " + y + "]");
        }
    }

    public class GreenCircle : IDraw
    {
        public void drawCircle(int radius, int x, int y)
        {
            Console.WriteLine("Drawing Circle[ color: green, radius: " + radius + ", x: " + x + ", " + y + "]");
        }
    }
}