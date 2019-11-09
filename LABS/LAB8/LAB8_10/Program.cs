using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - November 8, 2019

            /* Write and run a C# program that calculates and displays the amount of money available in 
             * a bank account that initially has $1,000 deposited in it and that earns 8 percent interest 
             * a year. Your program should display the amount available at the end of each year for a 
             * period of ten years. Use the relationship that the money available at the end of each year 
             * equals the amount of money in the account at the start of the year plus .08 times the 
             * amount available at the start of the year.
             * Your output should be formatted as shown below:
             * 
             * Year     Balance
             * 1        $1,080.00 
             * 2        $1,166.40 
             * ... 
             * */

            const int YEAR_PERIOD = 10;
            const double INTEREST = 0.08;
            double bankAccountTotal = 1000;

            Console.WriteLine("Year     Balance");

            for (int year = 1; year <= YEAR_PERIOD; ++year)
            {
                bankAccountTotal += bankAccountTotal * INTEREST;
                Console.WriteLine($"{year, -9}{bankAccountTotal, -9 :c}");
            }
        }
    }
}
