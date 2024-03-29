﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - November 10, 2019

            /* Write a program that calculates and displays the yearly amount available if $1,000 
             * is invested in a bank account for 10 years. Your program should display the amounts 
             * available for interest rates from 6 percent to 12 percent inclusively, at 1 percent 
             * increments. Use a nested loop, with the outer loop having a fixed count of 7 and the 
             * inner loop a fixed count of 10. The first iteration of the outer loop should use an 
             * interest rate of 6 percent and display the amount of money available at the end of 
             * the first 10 years. In each subsequent pass through the outer loop, the interest 
             * rate should be increased by 1 percent. Use the relationship that the money available 
             * at the end of each year equals the amount of money in the account at the start of the 
             * year plus the interest rate times the amount available at the start of the year.
             * [The output of this program should be in the form of a table] */

            const int STARTING_AMOUNT = 1000;
            double bankTotal = STARTING_AMOUNT;

            Console.WriteLine($"{"",-8}{"Interest",-10}{"Account",-20}");
            Console.WriteLine($"{"Year",-8}{"Rate (%)",-10}{"Total",-20}");
            Console.WriteLine("________________________________");

            for (double interestRates = 6; interestRates <= 12; ++interestRates)
            {
                for (int years = 1; years <= 10; ++years)
                {
                    bankTotal += (interestRates / 10) * bankTotal;
                    Console.WriteLine($"{years,-8}{interestRates,-10}{bankTotal,-20:c}");
                    bankTotal += STARTING_AMOUNT;
                }
                bankTotal = STARTING_AMOUNT;

                Console.WriteLine("________________________________");
            }
        }
    }
}
