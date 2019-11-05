using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_P7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            /* Write a console-based program that prompts the user for an 
             * hourly pay rate and hours worked. Compute gross pay (hours 
             * times pay rate), withholding tax, and net pay (gross pay minus 
             * withholding tax). Withholding tax is computed as a percentage 
             * of gross pay based on the following:
             * Gross Pay                    Withholding Percentage
             * Up to and including $300     10%
             * More than $300               12% */

            double hourlyPayRate;
            double hoursWorked;
            double grossPay;
            double withholdingTax;
            double netPay;
            const int GROSS_PAY_AMOUNT = 300;
            const double TAX_MIN = 0.1;
            const double TAX_MAX = 0.12;

            Console.WriteLine("Please enter your hourly pay rate:");
            hourlyPayRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the number of hours worked:");
            hoursWorked = Convert.ToDouble(Console.ReadLine());

            grossPay = hoursWorked * hourlyPayRate;

            if (grossPay <= GROSS_PAY_AMOUNT)
            {
                withholdingTax = grossPay * TAX_MIN;
            }
            else
            {
                withholdingTax = grossPay * TAX_MAX;
            }

            netPay = grossPay - withholdingTax;

            Console.WriteLine($"{"Gross Pay:", -20} {grossPay, 7:c} \n{"Withholding Tax:", -20} {withholdingTax, 7} \n{"Net Pay:", -20} {netPay, 7:c}");
        }
    }
}
