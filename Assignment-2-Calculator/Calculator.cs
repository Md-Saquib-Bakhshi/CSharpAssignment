using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_Calculator
{
    internal class Calculator : ICalculator
    {
        public int AddNumber(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
        }

        public int SubtractNumber(int firstNumber, int secondNumber)
        {
            int result = firstNumber - secondNumber;
            return result;
        }

        public int MultiplyNumber(int firstNumber, int secondNumber)
        {
            int result = firstNumber * secondNumber;
            return result;
        }

        public int DivideNumber(int firstNumber, int secondNumber)
        {
            int result = firstNumber / secondNumber;
            return result;
        }
    }
}
