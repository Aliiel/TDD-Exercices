using Panier.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Panier.Core
{
    public sealed class ShoppingCart
    {

        List<CartItem> Cart = new List<CartItem>();

        public int GetItemCount()
        {
            throw new NotImplementedException();
        } 

        public void AddItem(string name, decimal price, int quantity)
        {
            if (name  == null) throw new CartItemNameException("Le nom de l'article ne peut pas être nul");

            throw new NotImplementedException();
        }

        public decimal GetTotal()
        {
            throw new NotImplementedException();
        } 

        public void ApplyDiscount(decimal percentage)
        {
            throw new NotImplementedException();
        }
    }
}
