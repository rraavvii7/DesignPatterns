
using DesignPatterns.Structural.FacadeDesignPattern.ShoppingCart.Models;

namespace DesignPatterns.Structural.FacadeDesignPattern.ShoppingCart.Interfaces
{
    public interface ICart
    {
        Product GetItemDetails(int itemID);
        bool CheckItemAvailability(Product product);
        bool LockItemInStock(int itemID, int quantity);
        int AddItemToCart(int itemID, int quantity);
        double GetCartPrice(int cartID);
    }
}
