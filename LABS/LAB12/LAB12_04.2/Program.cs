using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_04._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - December 2, 2019

            /* [Part 4: Question 2]
             * Write a method call CubeIt(int x, ref int cube) that takes two arguments and does not return
             * a value. The method will cube the first argument and assign it to the second argument. */

            int x = 5;
            int cube = 0;

            Console.WriteLine($"{x}, {cube}");
            CubeIt(x, ref cube);
            Console.WriteLine($"{x}, {cube}");
        }

        static void CubeIt(int x, ref int cube)
        {
            cube = x * x * x;
        }
    }
}
