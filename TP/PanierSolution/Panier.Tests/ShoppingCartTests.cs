using Panier.Core;
using Panier.Core.Exceptions;

namespace Panier.Tests;

[TestClass]
public class ShoppingCartTests
{
    private ShoppingCart _cart = new ShoppingCart(new List<CartItem>());


    [TestMethod]
    public void GetItemCount_NewCart_Contains_0_Articles()
    {
        Assert.AreEqual(0, _cart.GetItemCount());
    }

    [TestMethod]
    public void GetTotal_EmptyCart_Return_0()
    {
        Assert.AreEqual(0, _cart.GetTotal());
    }

    [TestMethod]
    public void ApplyDiscount_When_EmptyCart_Then_EmptyCartApplyDiscountException()
    {
        Assert.ThrowsExactly<EmptyCartApplyDiscountException>(() => _cart.ApplyDiscount(0.3m));
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
