
namespace DesignPatterns.Structural.FacadeDesignPattern.ShoppingCart.Models
{
    public class Cart
    {
        public int CartID { get; set; }
        public int UserID { get; set; }
        public IEnumerable<CartItem> ShoppingCart { get; set; }
    }
}
