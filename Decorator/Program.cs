namespace Decorator
{
    using Decorators;
    using Entities;
    using Interfaces;
    using System;

    class Program
    {
        static void Main()
        {
            IPizza pizza = new BigPizza();
            PrintInfo(pizza);

            pizza = new HamDecorator(pizza);
            PrintInfo(pizza);

            pizza = new CheeseDecorator(pizza);
            PrintInfo(pizza);
        }

        public static void PrintInfo(IPizza pizza)
        {
            Console.WriteLine("-----------------\nCost: " + pizza.Price() + ";\nIngredients: " + pizza.Ingredients());
        }
    }
}