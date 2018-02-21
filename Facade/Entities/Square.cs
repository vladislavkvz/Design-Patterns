namespace Facade.Entities
{
    using Interface;
    using System;

    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Square drawing..");
        }
    }
}