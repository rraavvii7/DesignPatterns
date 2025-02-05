
namespace DesignPatterns.Structural.FlyweightDesignPattern
{
    public sealed class CarFactory : ICarFactory
    {
        private readonly IDictionary<string, ICar> _cars = new Dictionary<string, ICar>();

        private static readonly Lazy<CarFactory> _lazyInstance = new Lazy<CarFactory>(() => new CarFactory());

        public static CarFactory Instance => _lazyInstance.Value;

        public ICar GetCar(string type)
        {
            if (_cars.ContainsKey(type)) 
            { 
                return _cars[type]; 
            }
            else
            {
                var car = CreateCar(type);
                _cars.Add(type, car);
                return car;
            }
        }

        private ICar CreateCar(string type)
        {
            return type switch
            {
                "Bmw" => new BmwCar("V8", "Red"),
                "Audi" => new AudiCar("V6", "Blue"),
                _ => throw new ArgumentException("Invalid choice : {0}", type)
            };
        }
    }
}
