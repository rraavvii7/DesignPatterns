
using DesignPatterns.Structural.DecoratorDesignPattern.Component;

namespace DesignPatterns.Structural.DecoratorDesignPattern.ConcreteComponent
{
    public sealed class Suzuki : ICar
    {
        public string Make => "Sedan";

        public double GetPrice()
        {
            return 100000;
        }
    }
}
