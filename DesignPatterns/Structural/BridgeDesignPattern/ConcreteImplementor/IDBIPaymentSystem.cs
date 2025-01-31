using DesignPatterns.Structural.BridgeDesignPattern.Implementor;

namespace DesignPatterns.Structural.BridgeDesignPattern.ConcreteImplementor
{
    public class IDBIPaymentSystem : IPaymentSystem
    {
        public void ProcessPayment(string paymentSystem)
        {
            Console.WriteLine("Using IDBI payment gateway for {0}", paymentSystem);
        }
    }
}
