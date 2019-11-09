using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - November 8, 2019

            /* Write a Program to compute the sum of eight numbers that will be provided by the user. */

            int sum = 0;

            Console.WriteLine("You will enter 8 numbers and they will all be added together.\n");

            for (int count = 0; count < 8; ++count)
            {
                Console.WriteLine("Enter a number to add to the total below:");
                sum += Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"The total is: {sum}");
        }
    }
}
