using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_Palindrome
{
    internal class Palindrome
    {
        private string inputString;

        public string InputString
        {
            get
            {
                return inputString.ToLower();
            }
            set
            {
                if (value == "" || value == " ")
                {
                    Console.WriteLine("String must not be empty.");
                    return;
                }
                inputString = value;
            }
        }

        public Palindrome(string inputString)
        {
            InputString = inputString;
        }

        public bool IsPalindrome()
        {
            int i = 0;
            int j = InputString.Length-1;
            while (i <= j)
            {
                if(InputString[i] != InputString[j])
                {
                    return false;
                }
                i++; 
                j--;
            }
            return true;
        }

        public override string ToString()
        {
            if (IsPalindrome())
            {
                return $"{InputString} is Palindrome.";
            }
            return $"{InputString} is not Palindrome.";
        }
    }
}
