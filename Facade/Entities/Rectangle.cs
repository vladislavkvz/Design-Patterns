namespace Facade.Entities
{
    using Interface;
    using System;

    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle drawing..");
        }
    }
}