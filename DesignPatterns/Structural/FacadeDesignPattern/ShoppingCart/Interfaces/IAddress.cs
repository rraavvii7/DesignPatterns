

using DesignPatterns.Structural.FacadeDesignPattern.ShoppingCart.Models;

namespace DesignPatterns.Structural.FacadeDesignPattern.ShoppingCart.Interfaces
{
    public interface IAddress
    {
        Address GetAddressDetails(int userID);
    }
}
