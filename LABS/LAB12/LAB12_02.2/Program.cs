using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_02._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - November 30, 2019

            /* [Part 2: Question 2] 
             * Write a method that displays a vertical line of stars. Call this method, this time with arguments 0, 5, and 10. */

            DisplayVerticalStars(0);
            Console.WriteLine();
            DisplayVerticalStars(5);
            Console.WriteLine();
            DisplayVerticalStars(10);
        }

        static void DisplayVerticalStars(int numberOfStars)
        {
            for (int i = 0; i < numberOfStars; ++i)
            {
                Console.Write("*\n");
            }
        }
    }
}
