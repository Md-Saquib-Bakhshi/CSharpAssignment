using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_Temperature
{
    internal interface ITemperature
    {
        double Fahrenheit_To_Celsius(double temperature);
        double Celsius_To_Fahrenheit(double temperature);
    }
}
