namespace FactoryMethod
{
    using Entities;
    using Factories;

    class Program
    {
        static void Main()
        {
            ICarFactory factory = new MercedesFactory();
            ICar car = factory.CreateCar();

            car.MakeSound();
        }
    }
}