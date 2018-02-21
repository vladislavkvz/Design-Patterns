namespace AbstractFactory.Interfaces
{
    public interface ICarFactory
    {
        ICar GetCar();
        IEngine GetEngine();
    }
}