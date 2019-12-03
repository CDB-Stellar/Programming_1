using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_03._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - December 2, 2019

            /* [Part 3: Question 4]
             * Write a method called CalculateCommission(double saleAmount). This method will calculate
             * and return a sales representation’s commission. [over 1000 1% commission]. Call the 
             * CalculateCommission() method three times from your program Main() method, supplying 900,
             * 1000 and 2000. */

            Console.WriteLine($"{CalculateCommission(900):c}");
            Console.WriteLine($"{CalculateCommission(1000):c}");
            Console.WriteLine($"{CalculateCommission(2000):c}");
        }

        static double CalculateCommission(double saleAmount)
        {
            double commission = 0f;
            if (saleAmount > 1000)
                commission = saleAmount * 0.01;
            return commission;
        }
    }
}
