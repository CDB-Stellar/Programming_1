using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_03._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - November 30, 2019

            /* [Part 2: Question 3] 
             * Write a method that accepts an argument of type double. The method will calculate and display the 
             * volume of a sphere with radius specified by its argument. [V=43πr3]. Call this method from Main with 
             * arguments 1, 2, and 10. The answers are 4.1887, 33.5103 and 4188.7902 respectively.
             * (Use Math.PI for the value of π) */

            VolumeOfSphere(1);
            VolumeOfSphere(2);
            VolumeOfSphere(10);
        }

        static void VolumeOfSphere(double radius)
        {
            double volume = ((4 / 3) * Math.PI) * (radius * radius * radius);

            Console.WriteLine($"The volume is: {volume:f4}");
        }
    }
}
