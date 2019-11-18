using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // November 15, 2019

            int test0;
            int test1;
            int test2;
            int test3;
            double average;

            test0 = 100;
            test1 = 90;
            test2 = 80;
            test3 = 70;

            average = (test0 + test1 + test2 + test3) / 4.0;

            Console.WriteLine($"Average is {average}.");
        }
    }
}
