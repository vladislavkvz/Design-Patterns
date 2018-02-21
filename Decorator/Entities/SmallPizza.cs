namespace Decorator.Entities
{
    using Interfaces;

    public class SmallPizza : IPizza
    {
        public string Ingredients()
        {
            return "200gr. butter\ntomato sauce\npeperoni\ncheese";
        }

        public double Price()
        {
            return 5.0;
        }
    }
}