
namespace DesignPatterns.Structural.FlyweightDesignPattern
{
    public class BmwCar : ICar
    {
        public string Color { get; private set; }

        public string Engine { get; private set; }

        public BmwCar(string engine, string color)
        {
            Color = color;
            Engine = engine;
        }

        public void SetLocation(decimal lat, decimal lon)
        {
            Console.WriteLine("Current location of BMW car Color : {0}, Engine : {1} is {2} {3}", Color, Engine, lat, lon);
        }
    }
}
