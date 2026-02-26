using Panier.Core;
using Panier.Core.Exceptions;

namespace Panier.Tests;

[TestClass]
public class ShoppingCartTests
{
    private ShoppingCart _cart = new();

    [TestMethod]
    public void NewCart_Contains_0_Articles()
    {
        Assert.AreEqual(0, _cart.GetItemCount());
    }


    [TestMethod]
    public void AddItem_Name_Is_Not_Null()
    {
        Assert.Throws<CartItemNameException>(() => _cart.AddItem(null, 12.3m, 3));
    }

    [TestMethod]
    public void AddItem_Name_Is_Not_Empty()
    {
        Assert.Throws<CartItemNameException>(() => _cart.AddItem(string.Empty, 12.3m, 3));
    }

}
