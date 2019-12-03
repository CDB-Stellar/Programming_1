using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_03._13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - December 2, 2019

            /* [Part 3: Question 13]
             * Write two methods that will be called from main. The first method should prompt the user
             * for his daily sales amount. The method should accept and return this amount. The second 
             * method should calculate and return his commission based on the following: 0-999 3%, 
             * 1000-2999 4% and over 3000 5%. In your main call the two methods and display the results
             * in a readable manner. */

            Console.WriteLine($"{CalculateCommission(DailySalesAmount()):c}");
        }

        static double DailySalesAmount()
        {
            double salesAmount;
            Console.Write("Enter the daily sales amount: ");
            salesAmount = Convert.ToDouble(Console.ReadLine());
            return salesAmount;
        }

        static double CalculateCommission(double salesAmount)
        {
            double commission;
            if (salesAmount < 1000)
                commission = salesAmount * 0.03;
            else if (salesAmount < 3000)
                commission = salesAmount * 0.04;
            else
                commission = salesAmount * 0.05;
            return commission;
        }
    }
}
