using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6_P7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - October 24, 2019

            /* Write a program to calculate the roots of a quadratic equation. The 
             * flowchart below illustrates a possible solution: 
             * (refer to word document) */

            double a;
            double b;
            double c;
            double p;
            double d;
            double q;

            Console.WriteLine("This program will calculate the roots of a quadratic equation.");
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToDouble(Console.ReadLine());

            if (a != 0)
            {
                p = (-1 * b) / (2 * a);
                d = (b * b) - (4 * a * c); 

                if (d >= 0)
                {
                    q = Math.Sqrt(d) / (2 * a);
                    Console.WriteLine($"{p + q:f3} {p - q:f3}");
                }
                else
                {
                    q = Math.Sqrt(-1 * d) / (2 * a);
                    Console.WriteLine($"{p + q:f3}i {p - q:f3}i");
                }
            }
            else
            {
                Console.WriteLine("Invalid value of 'a'");
            }
        }
    }
}
