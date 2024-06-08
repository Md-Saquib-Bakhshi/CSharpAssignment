using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_Temperature
{
    internal class Temperature : ITemperature
    {
        public double TemperatureValue { get; set; }

        public double Fahrenheit_To_Celsius(double temperature)
        {
            double celsius = (temperature - 32) / 1.8;
            return celsius;
        }

        public double Celsius_To_Fahrenheit(double temperature)
        {
            double fahrenheit = ((temperature * 9) / 5) + 32; 
            return fahrenheit;
        }
    }
}
