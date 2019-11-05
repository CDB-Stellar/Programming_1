using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6_P9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - October 24, 2019

            /* Write a program that calculates the tax on an item, based on the 
             * province code. Your program will prompt the user for the 2-letter 
             * province code, and the cost of the item and then computes the tax 
             * based on the following table:
             * Province     Rate
             * ON           14%
             * PQ           13%
             * Any other    0%
             * Use named constants and if’s. Try to accommodate all permutations 
             * of the 2-letter code. */

            const double ON_TAX = 0.14;
            const double PQ_TAX = 0.13;
            string province;
            double itemCost;

            Console.Write("Please enter the cost of the item: $");
            itemCost = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the province (Example: ON): ");
            province = Console.ReadLine().ToUpper();

            switch (province)
            {
                case "ON":
                    Console.WriteLine($"Item cost: {itemCost * ON_TAX:c}");
                    break;
                case "PQ":
                    Console.WriteLine($"Item cost: {itemCost * PQ_TAX:c}");
                    break;
                default:
                    Console.WriteLine($"Item cost: {itemCost:c}");
                    break;
            }
        }
    }
}
