using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - November 8, 2019

            /* Write a C# program that displays a conversion table from gallons to liters. The program should display gallons 
             * from 10 to 20 in one-gallon increments and the corresponding litre equivalents. Use the relationship that 1 
             * gallon contains 3.785 liters. */

            const double LITRES_IN_GALLONS = 3.785;
            double litres;

            for (int gallons = 10; gallons <= 20; ++gallons)
            {
                litres = gallons * LITRES_IN_GALLONS;
                Console.WriteLine($"{gallons} gallons  =  {litres} litres");
            }
        }
    }
}
