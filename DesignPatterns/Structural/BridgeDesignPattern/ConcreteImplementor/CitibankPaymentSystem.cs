using DesignPatterns.Structural.BridgeDesignPattern.Implementor;

namespace DesignPatterns.Structural.BridgeDesignPattern.ConcreteImplementor
{
    public class CitibankPaymentSystem : IPaymentSystem
    {
        public void ProcessPayment(string paymentSystem)
        {
            Console.WriteLine("Using CitiBank payment gateway for {0}", paymentSystem);
        }
    }
}
