
using DesignPatterns.Structural.DecoratorDesignPattern.Component;
using DesignPatterns.Structural.DecoratorDesignPattern.Decorator;

namespace DesignPatterns.Structural.DecoratorDesignPattern.ConcreteDecorator
{
    public class OfferPrice : CarDecorator
    {
        public OfferPrice(ICar car) : base(car)
        {
            
        }
        public override double GetDiscountedPrice(double discount)
        {
            return discount * base.GetPrice();
        }
    }
}
