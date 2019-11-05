using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1_P2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            /* Loreto Farms wants a program to estimate the cost of fertilizing their fields 
             * for the coming year. The program will prompt the user for the rate of 
             * fertilizer application (how many kg per hectares), the unit price of 
             * fertilizer (dollars per kg) and the size (hectares)of land to be cultivated 
             * and then calculate and display the cost. */

            int kgPerHectare;
            int fertilizerPrice;
            int landSize;
            int totalCost;

            Console.WriteLine("This program will estimate the cost of fertilizing fields.");

            Console.Write("Please enter how many kg per hectare of fertilizer is needed: ");
            kgPerHectare = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the price of fertilizer in dollars per kg: $");
            fertilizerPrice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the size of land in hectares: ");
            landSize = Convert.ToInt32(Console.ReadLine());

            totalCost = kgPerHectare * landSize * fertilizerPrice;

            Console.WriteLine($"The estimated cost for {landSize} hectares is ${totalCost}.");
        }
    }
}
