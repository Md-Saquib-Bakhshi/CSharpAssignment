using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem
{
    internal static class Validator
    {
        public static bool PriceValidator(double price)
        {
            if (price < 0)
            {
                return false;
            }
            return true;
        }
    }
}
