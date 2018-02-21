namespace Decorator.Decorators
{
    using Interfaces;

    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string Ingredients()
        {
            return base.Ingredients() + "\nwith extra cheese";
        }

        public override double Price()
        {
            return base.Price() + 1.2;
        }
    }
}
