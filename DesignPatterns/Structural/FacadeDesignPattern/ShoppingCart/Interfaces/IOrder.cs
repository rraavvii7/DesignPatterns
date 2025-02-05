
namespace DesignPatterns.Structural.FacadeDesignPattern.ShoppingCart.Interfaces
{
    public interface IOrder
    {
        int PlaceOrderDetails(int cartID, int shippingAddressID);
    }
}
