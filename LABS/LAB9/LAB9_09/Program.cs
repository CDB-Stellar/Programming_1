using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB9_09
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - November 19, 2019

            /* Write a program that computes commissions for automobile salespeople based on the value of the car. 
             * Salespeople receive 5% of the sale price for any car sold for up to and including $15,000; 7% for any 
             * car over $15,000 up to and including $24,000; and 10% of the sale price of any car over $24,000. 
             * Write a program that allows a user to enter a car price. The output is the salesperson’s commission.
             * (Use parallel arrays.) */

            int[] salePrice = { 1, 15001, 24001 };
            double[] commissionPercentages = { 0.05, 0.07, 0.10 };
            int carPrice;
            int range = salePrice.Length - 1;
            double commission;

            Console.Write("Please enter the price of the car: $");
            carPrice = Convert.ToInt32(Console.ReadLine());

            while (range >= 0 && carPrice < salePrice[range])
            {
                --range;
            }

            commission = carPrice * commissionPercentages[range];
            Console.WriteLine($"The commisison is: {commission:c}");
        }
    }
}
