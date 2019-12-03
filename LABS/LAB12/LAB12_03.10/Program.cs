using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_03._10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - December 2, 2019

            /* [Part 3: Question 10]
             * Write a method called ConvertCelsiusToKelvin that takes a double argument. The method will
             * calculate and return the Kelvin equivalent of the argument. [K = C + 273.15]. In your main
             * call this method with arguments -196, 0 and 100 and display the results. */

            Console.WriteLine(ConvertCelsiusToKelvin(-196f));
            Console.WriteLine(ConvertCelsiusToKelvin(0f));
            Console.WriteLine(ConvertCelsiusToKelvin(100f));
        }

        static double ConvertCelsiusToKelvin(double celsius)
        {
            double kelvin = celsius + 273.15;
            return kelvin;
        }
    }
}
