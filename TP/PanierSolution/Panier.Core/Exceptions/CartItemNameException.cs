using System;
using System.Collections.Generic;
using System.Text;

namespace Panier.Core.Exceptions
{
    public class CartItemNameException : Exception
    {
        public CartItemNameException(string message) : base(message)
        {
            
        }
    }
}
