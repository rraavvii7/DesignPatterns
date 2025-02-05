using DesignPatterns.Structural.FacadeDesignPattern.ShoppingCart.Interfaces;
using DesignPatterns.Structural.FacadeDesignPattern.ShoppingCart.Models;

namespace DesignPatterns.Structural.FacadeDesignPattern.ShoppingCart.Implementations
{
    public class AddressDetail : IAddress
    {
        public Address GetAddressDetails(int userID)
        {
            Console.WriteLine("\t SubSystem Address : GetAddressDetails");
            return new Address();
        }
    }
}
