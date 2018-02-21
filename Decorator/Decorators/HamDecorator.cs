namespace Decorator.Decorators
{
    using Interfaces;

    public class HamDecorator : PizzaDecorator
    {
        public HamDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string Ingredients()
        {
            return base.Ingredients() + "\nwith ham";
        }

        public override double Price()
        {
            return base.Price() + 1.5;
        }
    }
}