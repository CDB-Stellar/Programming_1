using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - COMP100-005

            /* A confectionary store wants a program that will prompt the user for the 
             * price of the candy and the amount of money she would like to spend and 
             * then calculates and display the amount of candies that can be purchased. */

            double candyPrice;
            double moneyToSpend;

            Console.WriteLine("This program will calculate how many candies you can buy based on how much money you have.\n");

            Console.Write("Please enter the price of the candy: $");
            candyPrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter how much money you have to spend: $");
            moneyToSpend = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\nYou can purchase {(int)(moneyToSpend / candyPrice)} candies with {moneyToSpend:c}.");
        }
    }
}
