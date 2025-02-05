
namespace DesignPatterns.Structural.FlyweightDesignPattern
{
    public interface ICarFactory
    {
        ICar GetCar(string type);
    }
}
