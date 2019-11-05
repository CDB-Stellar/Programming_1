using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - COMP100-005

            /* Othello’s Grocery would like a program that will prompt the user for the 
             * weight and price of the produce, the price and capacity of plastic bag 
             * and then calculates and displays the total cost of the sale. You may 
             * assume that all customers will require bags. You may use the following 
             * sample inputs: price 11₵per kg, weight 25kg and price of a plastic bag 5₵. */

            double produceWeight;
            double producePrice;
            double bagPrice;
            double bagCapacity;
            double totalCostOfSale;

            Console.WriteLine("This program will calculate the total cost of the sale.\n");

            Console.Write("Please enter the weight of the produce in kg: ");
            produceWeight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the price of the produce: $");
            producePrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the price of the bag: $");
            bagPrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the capacity of the bag in kg: ");
            bagCapacity = Convert.ToDouble(Console.ReadLine());

            if (produceWeight % bagCapacity != 0)
            {
                totalCostOfSale = ((int)(produceWeight / bagCapacity) + 1) * bagPrice + producePrice;
            }
            else
            {
                totalCostOfSale = (produceWeight / bagCapacity * bagPrice) + producePrice;
            }

            Console.WriteLine($"\nThe total cost of the sale is {totalCostOfSale:c}.");
        }
    }
}
