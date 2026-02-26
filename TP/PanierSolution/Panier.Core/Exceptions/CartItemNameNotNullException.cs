using System;
using System.Collections.Generic;
using System.Text;

namespace Panier.Core.Exceptions
{
    public class CartItemNameNotNullException : Exception
    {
        public CartItemNameNotNullException() : base("Le nom de l'article ne peut pas être nul")
        {
            
        }
    }
}
