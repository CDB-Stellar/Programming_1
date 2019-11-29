using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - November 29, 2019

            /* Write a method called CalculateSaleCommission(), that prompts the user for his sales figure, and 
             * then calculates and displays his commission. 
             * (commission = 25% of sales in excess of 1000. If sales is below $1000.00 there is no commission) */

            CalculateSaleCommission();
        }

        static void CalculateSaleCommission()
        {
            double salesFigure;
            double commission;

            Console.Write("Enter the sales figure: ");
            salesFigure = Convert.ToDouble(Console.ReadLine());

            if (salesFigure > 1000)
                commission = 0.25 * salesFigure;
            else
                commission = 0;

            Console.WriteLine($"The commision is: {commission:c}");
        }
    }
}
