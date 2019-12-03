using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_03._9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - December 2, 2019

            /* [Part 3: Question 9]
             * Write a method called ConvertFahrenheitToCelsius that takes a double argument. The method will
             * calculate and return the Celsius equivalent of the argument. [C = (F – 32) * 5 / 9]. In your 
             * main call this method with arguments 0, 32 and 212 and display the results. */

            Console.WriteLine(ConvertFahrenheitToCelsius(0f));
            Console.WriteLine(ConvertFahrenheitToCelsius(32f));
            Console.WriteLine(ConvertFahrenheitToCelsius(212f));
        }

        static double ConvertFahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }
    }
}
