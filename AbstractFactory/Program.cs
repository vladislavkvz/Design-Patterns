namespace AbstractFactory
{
    using Factories;
    using Interfaces;
    using System;

    class Program
    {
        static void Main()
        {
            ICarFactory factory = new EUCarFactory();
            ICar car= factory.GetCar();
            Console.WriteLine(car.GetType().Name);
        }
    }
}