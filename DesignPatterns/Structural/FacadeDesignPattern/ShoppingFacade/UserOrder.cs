﻿
using DesignPatterns.Structural.FacadeDesignPattern.ShoppingCart.Implementations;
using DesignPatterns.Structural.FacadeDesignPattern.ShoppingCart.Interfaces;
using DesignPatterns.Structural.FacadeDesignPattern.ShoppingCart.Models;

namespace DesignPatterns.Structural.FacadeDesignPattern.ShoppingFacade
{
    public class UserOrder : IUserOrder
    {
        public int AddToCart(int itemId, int qty)
        {
            Console.WriteLine("Start AddToCart");
            ICart userCart = new ShoppingCartDetail();
            int cartID = 0;
            //Step 1 : GetItem
            Product product = userCart.GetItemDetails(itemId);
            //Step 2 : Check Availability
            if (userCart.CheckItemAvailability(product))
            {
                //Step 3 : Lock Item in the Stock
                userCart.LockItemInStock(itemId, qty);
                //Step 4 : Add Item to the cart
                cartID = userCart.AddItemToCart(itemId, qty);
            }
            Console.WriteLine("End AddToCart");
            return cartID;
        }

        public int PlaceOrder(int cartID, int userID)
        {
            Console.WriteLine("Start PlaceOrderDetails");
            int orderID = -1;
            IWallet wallet = new Wallet();
            ITax tax = new Tax();
            ICart userCart = new ShoppingCartDetail();
            IAddress address = new AddressDetail();
            IOrder order = new Order();
            //Step 1 : Get Tax percentage by State
            double stateTax = tax.GetTaxByState("ABC");
            //Step 2 : Apply Tax on the Cart Items
            tax.ApplyTax(cartID, stateTax);
            //Step 3 : Get user Wallet balance
            double userWalletBalance = wallet.GetUserBalance(userID);
            //Step 4 : Get the cart items price
            double cartPrice = userCart.GetCartPrice(cartID);
            //Step 5 : Compare the balance and price
            if (userWalletBalance > cartPrice)
            {
                //Step 6 : Get user Address and set to cart
                Address userAddress = address.GetAddressDetails(userID);
                //Step 7 : Place the order
                orderID = order.PlaceOrderDetails(cartID, userAddress.AddressID);

            }
            Console.WriteLine("End PlaceOrderDetails");
            return orderID;
        }
    }
}
