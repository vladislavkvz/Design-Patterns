namespace AbstractFactory.Factories
{
    using Entities;
    using Interfaces;

    public class USCarFactory : ICarFactory
    {
        public ICar GetCar()
        {
            return new USCar();
        }

        public IEngine GetEngine()
        {
            return new USEngine();
        }
    }
}