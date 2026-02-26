using Panier.Core;
using Panier.Core.Exceptions;

namespace Panier.Tests;

[TestClass]
public class ShoppingCartTests
{
    private ShoppingCart _cart = new();

    [TestMethod]
    public void AddItem_Name_Is_Not_Null()
    {
        // Assert 
        Assert.Throws<CartItemNameException>(() => _cart.AddItem(null, 12.3m, 3));
    }
   
}
