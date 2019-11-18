using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // November 15, 2019

            int[] test = new int[] {100, 90, 80, 70}; // leave new int[] empty so that the list size can change
            double average;
            int sum = 0;

            //test[0] = 100;    // instead of initializing individually, you can put values in curly braces
            //test[1] = 90;
            //test[2] = 80;
            //test[3] = 70;

            //average = (test[0] + test[1] + test[2] + test[3]) / 4.0;
            for (int i = 0; i < test.Length; ++i)
            {
                sum += test[i];
            }

            average = (double)sum / test.Length;    // this will calculate the average of a variable array size

            Console.WriteLine($"Average is {average}.");
        }
    }
}
