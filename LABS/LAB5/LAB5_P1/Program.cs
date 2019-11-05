using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            /* Write a console-based program that prompts the user for an hourly pay rate. 
             * If the value entered is less than $7.50, display an error message. */

            double hourlyPay;
            const double PAY_RATE = 7.5;

            Console.Write("Please enter your hourly pay rate: $");
            hourlyPay = Convert.ToDouble(Console.ReadLine());

            if (hourlyPay < PAY_RATE)
            {
                Console.WriteLine("Error. Pay rate is too low.");
            }
        }
    }
}
