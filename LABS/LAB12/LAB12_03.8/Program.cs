using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_03._8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - December 2, 2019

            /* [Part 3: Question 8]
             * Write a method called ConvertCelciusToFahrenheit that takes a double argument. The method will
             * calculate and return the Fahrenheit equivalent of the argument. [F = C * 9 / 5 + 32]. In your 
             * main call this method with arguments 0, 50 and 100 and display the results. */

            Console.WriteLine(ConvertCelciusToFahrenheit(0f));
            Console.WriteLine(ConvertCelciusToFahrenheit(50f));
            Console.WriteLine(ConvertCelciusToFahrenheit(100f));
        }

        static double ConvertCelciusToFahrenheit(double celsius)
        {
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }
    }
}
