using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - November 8, 2019

            /* Write a Program to compute the average of ten numbers which will be entered by the user. */

            double sum = 0;
            int count = 0;

            Console.WriteLine("You will enter 10 numbers and the averge will be calculated.\n");

            while (count < 10)
            {
                Console.WriteLine("Enter a number to add to the average below:");
                sum += Convert.ToInt32(Console.ReadLine());
                ++count;
            }
            
            Console.WriteLine($"The average is: {sum / count}");
        }
    }
}
