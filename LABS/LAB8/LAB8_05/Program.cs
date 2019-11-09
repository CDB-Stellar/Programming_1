using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - November 8, 2019

            /* Write a C# program that converts feet to meters. The program should display feet 
             * from 3 to 30 in three-foot increments and the corresponding meter equivalents. 
             * Use the relationship that 1 meter is equivalent to 3.28 feet. */

            double meters;

            for (int feet = 2; feet <= 30; feet += 3)
            {
                meters = feet / 3.28;
                Console.WriteLine($"{feet} feet  =  {meters:f2} meters");
            }
        }
    }
}
