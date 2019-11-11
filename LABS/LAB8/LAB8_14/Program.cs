using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - November 10, 2019

            /* a) Modify the program written for LAB8_13 to initially prompt the user for the amount of money initially 
             * deposited in the account. 
             * b) Modify the program written for LAB8_13 to initially prompt the user for both the amount of money initially 
             * deposited and the number of years that should be displayed. 
             * c) Modify the program written for LAB8_13 to initially prompt for the amount of money initially deposited, 
             * the interest rate to be used, and the number of years to be displayed. */

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
