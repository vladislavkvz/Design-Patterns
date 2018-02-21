namespace AbstractFactory.Factories
{
    using Entities;
    using Interfaces;

    public class EUCarFactory : ICarFactory
    {
        public ICar GetCar()
        {
            return new EUCar();
        }

        public IEngine GetEngine()
        {
            return new EUEngine();
        }
    }
}