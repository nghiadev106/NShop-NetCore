using System;
using System.Collections.Generic;
using System.Text;

namespace NShop.Common
{
    public class NShopException : Exception
    {
        public NShopException()
        {
        }

        public NShopException(string message)
            : base(message)
        {
        }

        public NShopException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
