using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_04._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - December 2, 2019

            /* [Part 4: Question 1]
             * Write a method call DoubleIt(ref int x) that takes a single argument and does
             * not return a value. The method will double the value of its argument. */

            int x = 5;

            Console.WriteLine(x);
            DoubleIt(ref x);
            Console.WriteLine(x);
        }

        static void DoubleIt(ref int x)
        {
            x = x * 2;
        }
    }
}
