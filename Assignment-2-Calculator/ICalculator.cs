using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_Calculator
{
    internal interface ICalculator
    {
        int AddNumber(int firstNumber, int secondNumber);
        int SubtractNumber(int firstNumber, int secondNumber);
        int MultiplyNumber(int firstNumber, int secondNumber);
        int DivideNumber(int firstNumber, int secondNumber);
    }
}
