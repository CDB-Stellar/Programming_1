using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_02._5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - December 2, 2019

            /* [Part 2: Question 5]
             * Write a method that takes a single argument of type double. Method will display a Celsius
             * to Fahrenheit conversion table. The starting temperature is indicated by the argument 
             * and it will display 10 lines in increments of 1. In your main call this method two 
             * times. */

            CelsiusToFahrenheitTable(1f);
            CelsiusToFahrenheitTable(20f);
        }

        static void CelsiusToFahrenheitTable(double startTemp)
        {
            for (int count = 0; count < 10; ++count)
            {
                Console.WriteLine($"{startTemp}°C  =  {(startTemp * 9 / 5) + 32}°F");
                ++startTemp;
            }
        }
    }
}
