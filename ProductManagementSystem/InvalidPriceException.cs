using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem
{
    internal class InvalidPriceException : Exception
    {
        public InvalidPriceException(string message) : base(message) { }
    }
}
