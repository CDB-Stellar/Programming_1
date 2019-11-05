using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - October 29, 2019

            /* A conversion table of Celsius to Fahrenheit temperature. The table must start 
             * with 0 Celsius and end at 100 Celsius with increments of 10. 
             * (Fahrenheit = Celsius * 9/5 + 32) */

            int counter = 0;

            do
            {
                Console.WriteLine($"{counter}°C  =  {counter * 9/5 + 32}°F");
                counter += 10;
            } while (counter <= 100);
        }
    }
}
