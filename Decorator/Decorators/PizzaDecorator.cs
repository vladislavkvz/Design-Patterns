namespace Decorator.Decorators
{
    using Interfaces;

    public abstract class PizzaDecorator : IPizza
    {
        protected IPizza decoratorPizza;

        public PizzaDecorator(IPizza pizza)
        {
            this.decoratorPizza = pizza;
        }

        public virtual string Ingredients()
        {
            return decoratorPizza.Ingredients();
        }

        public virtual double Price()
        {
            return decoratorPizza.Price();
        }
    }
}