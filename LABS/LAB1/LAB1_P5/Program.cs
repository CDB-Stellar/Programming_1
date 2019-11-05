using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1_P5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            /* Othello’s Grocery is small business located in the West Hill area. They 
             * would like a program that will prompt the user for the weight and price 
             * of the produce, the price and capacity of plastic bag and then calculate 
             * and display the total cost of the sale. You may assume that all 
             * customers will require bags. */

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
