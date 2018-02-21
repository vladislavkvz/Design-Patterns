namespace Facade
{
    class Program
    {
        static void Main()
        {
            ShapeMaker shapeMaker = new ShapeMaker();
            shapeMaker.DrawTriangle();
            shapeMaker.DrawRectangle();
            shapeMaker.DrawSquare();
        }
    }
}