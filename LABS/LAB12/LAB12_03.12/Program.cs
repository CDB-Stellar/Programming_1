using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_03._12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - December 2, 2019

            /* [Part 3: Question 12]
             * Write two methods: Square(int) and Cube(int), these methods return the square and the cube of
             * its argument. In your main method prompt the user for an integer, then pass this integer to 
             * the Square method and then pass the results to the Cube method. In the main method print out 
             * the final results. */

            int number;

            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Squared, then cubed: {Cube(Square(number))}");
        }

        static int Square(int number)
        {
            int square = number * number;
            return square;
        }

        static int Cube(int number)
        {
            int cube = number * number * number;
            return cube;
        }
    }
}
