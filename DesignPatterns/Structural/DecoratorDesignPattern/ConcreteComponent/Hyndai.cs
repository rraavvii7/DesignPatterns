
using DesignPatterns.Structural.DecoratorDesignPattern.Component;

namespace DesignPatterns.Structural.DecoratorDesignPattern.ConcreteComponent
{
    public sealed class Hyndai : ICar
    {
        public string Make => "HatchBack";

        public double GetPrice()
        {
            return 80000;
        }
    }
}
