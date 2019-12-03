using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_03._5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - December 2, 2019

            /* [Part 3: Question 5]
             * Write a method that does not take any argument. The method will prompt the user
             * for the number of burgers that he wants to buy. The method will calculate and 
             * return the amount of money that will be required. [One burger cost $1.39. */

            Console.WriteLine(CalculatePrice());
        }

        static double CalculatePrice()
        {
            const double BURGER_COST = 1.39;
            double price;
            int howManyBurgers;

            Console.Write("Enter how many burgers you will buy: ");
            howManyBurgers = Convert.ToInt32(Console.ReadLine());
            price = howManyBurgers * BURGER_COST;

            return price;
        }
    }
}
