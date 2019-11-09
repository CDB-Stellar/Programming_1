using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - November 8, 2019

            /* Write a program to print the numbers 2 to 10 in increments of two. The output of your 
             * program should be 2 4 6 8 10 */


            for (int number = 2; number <= 10; number += 2)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
