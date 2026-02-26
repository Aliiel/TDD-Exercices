using System;
using System.Collections.Generic;
using System.Text;

namespace Panier.Core.Exceptions
{
    public class EmptyCartApplyDiscountException : Exception
    {
        public EmptyCartApplyDiscountException(string message) : base(message)
        {
            
        }
    }
}
