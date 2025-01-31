using DesignPatterns.Structural.BridgeDesignPattern.Implementor;

namespace DesignPatterns.Structural.BridgeDesignPattern.Abstraction
{
    public abstract class Payment
    {
        public IPaymentSystem? paymentSystem;
        public abstract void MakePayment();
    }
}
