namespace FactoryMethod.Factories
{
    using Entities;

    public class MercedesFactory : ICarFactory
    {
        public ICar CreateCar()
        {
            return new Mercedes();
        }
    }
}