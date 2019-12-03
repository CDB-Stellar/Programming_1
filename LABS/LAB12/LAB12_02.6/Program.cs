using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_02._6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - December 2, 2019

            /* [Part 2: Question 6]
             * Write a method that takes the following arguments: a starting km value of type double,
             * an increment size of type double and the number of lines of type int. The display a 
             * kilometer to miles conversion table. [miles = km * 0.621371]. In your main call this 
             * method three times. */

            DisplayKilometersToMilesTable(1f, 1f, 5);
            DisplayKilometersToMilesTable(10f, 5f, 5);
            DisplayKilometersToMilesTable(2.3, 1f, 5);
        }

        static void DisplayKilometersToMilesTable(double km, double increment, int lines)
        {
            for (int x = 0; x < lines; ++x)
            {
                Console.WriteLine($"{km} km  =  {km / 1.609:f2} mi");
                km += increment;
            }
        }
    }
}
