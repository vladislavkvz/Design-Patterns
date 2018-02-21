namespace Bridge
{
    using Entities;

    class Program
    {
        static void Main()
        {
            Shape redCircle = new Circle(100, 100, 10, new RedCircle());
            Shape greenCircle = new Circle(100, 100, 10, new GreenCircle());
            redCircle.Draw();
            greenCircle.Draw();
        }
    }
}