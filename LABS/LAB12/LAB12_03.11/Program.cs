using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_03._11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - December 2, 2019

            /* [Part 3: Question 11]
             * Write a method call ConvertFahrenheitToKelvin that takes a double argument. The method will
             * calculate and return the Kelvin equivalent of the argument. [Use the two previous methods 
             * to assist in your computation]. In your main call this method three times and display the 
             * results. */

            Console.WriteLine(ConvertFahrenheitToKelvin(0f));
            Console.WriteLine(ConvertFahrenheitToKelvin(32f));
            Console.WriteLine(ConvertFahrenheitToKelvin(100f));
        }

        static double ConvertFahrenheitToKelvin(double fahrenheit)
        {
            double kelvin = (fahrenheit - 32) * 5 / 9 + 273.15;
            return kelvin;
        }
    }
}
