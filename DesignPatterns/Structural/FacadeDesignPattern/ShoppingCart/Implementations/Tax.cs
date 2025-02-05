using DesignPatterns.Structural.FacadeDesignPattern.ShoppingCart.Interfaces;

namespace DesignPatterns.Structural.FacadeDesignPattern.ShoppingCart.Implementations
{
    public class Tax : ITax
    {
        public void ApplyTax(int cartID, double taxPercent)
        {
            Console.WriteLine("\t SubSystem Tax : ApplyTax");
        }
        public double GetTaxByState(string state)
        {
            Console.WriteLine("\t SubSystem Tax : GetTaxByState");
            return 10;
        }
    }
}
