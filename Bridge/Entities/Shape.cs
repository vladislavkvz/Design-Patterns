namespace Bridge.Entities
{
    using Interfaces;

    public abstract class Shape
    {
        protected IDraw draw;

        public Shape(IDraw draw)
        {
            this.draw = draw;
        }

        public abstract void Draw();
    }
}