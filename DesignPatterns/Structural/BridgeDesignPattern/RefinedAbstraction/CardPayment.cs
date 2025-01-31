using DesignPatterns.Structural.BridgeDesignPattern.Abstraction;

namespace DesignPatterns.Structural.BridgeDesignPattern.RefinedAbstraction
{
    public class CardPayment : Payment
    {
        public override void MakePayment()
        {
            paymentSystem?.ProcessPayment("Card payment");
        }
    }
}
