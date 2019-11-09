using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8_08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - November 8, 2019

            /* Write a program to produce a table of numbers from 10 to 1, with their squares and cubes. */

            Console.WriteLine("Number | Squared | Cubed");

            for (int number = 1; number < 11; ++number)
            {
                Console.WriteLine($"{number, -6} | {number * number, -7} | {number * number * number, -9}");
            }
        }
    }
}
