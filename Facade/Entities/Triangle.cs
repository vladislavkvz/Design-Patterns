namespace Facade.Entities
{
    using Interface;
    using System;

    public class Triangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Triangle drawing..");
        }
    }
}