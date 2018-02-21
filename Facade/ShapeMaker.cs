namespace Facade
{
    using Entities;
    using Interface;

    public class ShapeMaker
    {
        private IShape triangle;
        private IShape rectangle;
        private IShape square;

        public ShapeMaker()
        {
            triangle = new Triangle();
            rectangle = new Rectangle();
            square = new Square();
        }

        public void DrawTriangle()
        {
            triangle.Draw();
        }
        public void DrawRectangle()
        {
            rectangle.Draw();
        }
        public void DrawSquare()
        {
            square.Draw();
        }
    }
}