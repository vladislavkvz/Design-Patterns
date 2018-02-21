namespace Decorator.Entities
{
    using Interfaces;

    public class BigPizza : IPizza
    {
        public string Ingredients()
        {
            return "500gr. butter\ntomato sauce\npeperoni\ncheese";
        }

        public double Price()
        {
            return 10.0;
        }
    }
}