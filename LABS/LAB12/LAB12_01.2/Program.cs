using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_01._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - November 30, 2019

            /* [Part 2: Question 1] 
             * Write a method called DisplayHorizontalStars(int numberOfStars). This method will output the number of 
             * stars horizontally specified by its argument. Call the DisplayHorizontalStars() method three times 
             * from Main(), supplying 0, 5 and 10 number of stars. */

            DisplayHorizontalStars(0);
            DisplayHorizontalStars(5);
            DisplayHorizontalStars(10);
        }

        static void DisplayHorizontalStars(int numberOfStars)
        {
            for (int i = 0; i < numberOfStars; ++i)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
