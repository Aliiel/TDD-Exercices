using Panier.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Panier.Core
{
    public sealed class ShoppingCart
    {
        private List<CartItem> _cart;
        private decimal _total;

        public ShoppingCart(List<CartItem> Cart)
        {
            _cart = Cart;
        }

        public int GetItemCount()
        {
            return _cart.Count;
        } 

        public void AddItem(string name, decimal price, int quantity)
        {
            if (name  == null) throw new CartItemNameException("Le nom de l'article ne peut pas être nul");

            throw new NotImplementedException();
        }

        public decimal GetTotal()
        {
            foreach (CartItem item in _cart)
            {
                _total += item.Price;
            }

            return _total;
        } 

        public void ApplyDiscount(decimal percentage)
        {
            throw new NotImplementedException();
        }
    }
}
