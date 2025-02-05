
namespace DesignPatterns.Structural.FlyweightDesignPattern
{
    public class CarManager : ICarManager
    {
        private decimal _lat = 0;
        private decimal _lon = 0;
        private readonly ICar _car;
        public CarManager(ICarFactory carFactory, string type)
        {
            _car = carFactory.GetCar(type);
        }
        public void SetLocation(decimal lat, decimal lon)
        {
            _lat = lat;
            _lon = lon;
            _car.SetLocation(lat, lon);
        }
    }
}
