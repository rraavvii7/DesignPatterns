
using DesignPatterns.Structural.FacadeDesignPattern.ShoppingCart.Interfaces;

namespace DesignPatterns.Structural.FacadeDesignPattern.ShoppingCart.Implementations
{
    public class Order : IOrder
    {
        public int PlaceOrderDetails(int cartID, int shippingAddressID)
        {
            Console.WriteLine("\t SubSystem Order : PlaceOrderDetails");
            return 10;
        }
    }
}
