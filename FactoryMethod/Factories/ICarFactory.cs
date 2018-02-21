namespace FactoryMethod.Factories
{
    using Entities;

    public interface ICarFactory
    {
        ICar CreateCar();
    }
}