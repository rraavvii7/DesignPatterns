using DesignPatterns.Structural.FacadeDesignPattern.ShoppingCart.Interfaces;

namespace DesignPatterns.Structural.FacadeDesignPattern.ShoppingCart.Implementations
{
    internal class Wallet : IWallet
    {
        public double GetUserBalance(int userID)
        {
            Console.WriteLine("\t SubSystem Wallet : GetUserBalance");
            return 100;
        }
    }
}
