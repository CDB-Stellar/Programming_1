using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6_P14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - October 24, 2019

            /* Write a program that prompts the user for an hourly pay rate 
             * and hours worked. Compute gross pay (hours times pay rate), 
             * withholding tax, and net pay (gross pay minus withholding tax). 
             * Withholding tax is computed as a percentage of gross pay based 
             * on the following:
             * Gross Pay                     Withholding Percentage 
             * Up to and including 300.00    10% 
             * 300.01 and up                 12%  */

            const int GROSS_PAY_LIMIT = 300;
            const double WITHHOLDING_10P = 0.1;
            const double WITHHOLDING_12P = 0.12;
            double hourlyPay;
            int hoursWorked;
            double withholdingTax;

            Console.Write("Please enter the hourly pay rate: $");
            hourlyPay = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the hours worked: $");
            hoursWorked = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{"Gross Pay:", -18} {hoursWorked * hourlyPay, 10:c}");

            if (hoursWorked * hourlyPay <= GROSS_PAY_LIMIT)
            {
                withholdingTax = hoursWorked * hourlyPay * WITHHOLDING_10P;
                Console.WriteLine($"{"Withholding Tax:",-18} {withholdingTax, 10:c}");
            }
            else
            {
                withholdingTax = hoursWorked * hourlyPay * WITHHOLDING_12P;
                Console.WriteLine($"{"Withholding Tax:",-18} {withholdingTax, 10:c}");
            }

            Console.WriteLine($"{"Net Pay:",-18} {(hoursWorked * hourlyPay) - withholdingTax,10:c}");
        }
    }
}
