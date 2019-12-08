using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChloeB_301062067_A6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - December 8, 2019

            /* Write a method named IsPerfect that ask user for an integer
             * number and display if the number is perfect. A number is 
             * perfect if it equals the sum of all the smaller positive 
             * integers that divide evenly into it. For example, 6 is 
             * perfect because 1, 2, and 3 divide evenly into it and their
             * sum is 6. Write method GetNumber that will keep asking user
             * to input an integer number until valid number is provided. 
             * This method will return provided value. In the Main method 
             * of the console application call GetNumber method to get the
             * user input. By calling IsPerfect method in main check if 
             * the number is perfect. Display the result. */

            IsPerfect(GetNumber());
        }

        static void IsPerfect(int integer)
        {
            int sum = 1; // 1 is always a proper factor

            for (int factor = 2; factor < integer; ++factor)
            {
                if (integer % factor == 0) // if factor is a proper factor
                    sum += factor;
            }
            
            if (sum == integer)
                Console.WriteLine("This is a perfect number.");
            else
                Console.WriteLine("This is not a perfect number.");
        }

        static int GetNumber()
        {
            int integer = 0;

            Console.Write("Enter an integer: ");
            while (!int.TryParse(Console.ReadLine(), out integer))
                Console.Write("Invalid. Please enter an integer: ");

            return integer;
        }
    }
}
