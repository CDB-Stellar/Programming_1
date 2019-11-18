using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // November 15, 2019

            // if you have more than 4 varibles, just use an array
            //int test0;
            //int test1;
            //int test2;
            //int test3;
            int[] test = new int[4];
            double average;

            //test0 = 100;
            //test1 = 90;
            //test2 = 80;
            //test3 = 70;
            test[0] = 100;
            test[1] = 90;
            test[2] = 80;
            test[3] = 70;

            average = (test[0] + test[1] + test[2] + test[3]) / 4.0;

            Console.WriteLine($"Average is {average}.");
        }
    }
}
