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
            // Chloe Baker - 301062067 - December 2, 2019

            /* [Part 3: Question 2] 
             * Write a method called CalculatePower(double current, double resistance). The method will
             * calculate and return the electrical power dissipated in a circuit [P=I^2R]. */

            Console.WriteLine($"{CalculatePower(5f,10f)}");
        }

        static double CalculatePower(double current, double resistance)
        {
            double power = (current * current) * resistance;
            return power;
        }
    }
}
