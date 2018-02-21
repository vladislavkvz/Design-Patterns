namespace FactoryMethod.Factories
{
    using Entities;

    public class AudiFactory : ICarFactory
    {
        public ICar CreateCar()
        {
            return new Audi();
        }
    }
}