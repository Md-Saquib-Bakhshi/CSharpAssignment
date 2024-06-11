using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment_5_Finally
{
    internal static class NumberValidator
    {
        public static void NumberValidate(int number)
        {
            if (!(number >= 1 && number <= 10))
            {
                throw new NumberException("Number must be lies between 1 - 10");
            }
        }
    }
}
