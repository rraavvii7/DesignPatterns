
using DesignPatterns.Structural.BridgeDesignPattern.Abstraction;

namespace DesignPatterns.Structural.BridgeDesignPattern.RefinedAbstraction
{
    public class NetbankingPayment : Payment
    {
        public override void MakePayment()
        {
            paymentSystem?.ProcessPayment("Netbanking payment");
        }
    }
}
