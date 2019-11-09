using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8_07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - November 8, 2019

            /* Write a program to produce a table of the numbers 0 through 20 in increments of 2, with their 
             * squares and cubes. */

            for (int number = 0; number < 21; number += 2)
            {
                Console.WriteLine($"{number, -2} squared: {number * number, -3} cubed: {number * number * number, -4}");
            }
        }
    }
}
