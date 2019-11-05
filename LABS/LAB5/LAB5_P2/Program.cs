using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_P2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            /* Write a console-based program that prompts a user for an 
             * hourly pay rate. If the value entered is less than $7.50 
             * or greater than $49.99, display an error message; otherwise, 
             * display a message indicating that the rate is okay. */

            double hourlyPay;
            const double MIN_PAY_RATE = 7.5;
            const double MAX_PAY_RATE = 49.99;

            Console.Write("Please enter your hourly pay rate: $");
            hourlyPay = Convert.ToDouble(Console.ReadLine());

            if (hourlyPay < MIN_PAY_RATE || hourlyPay > MAX_PAY_RATE)
            {
                Console.WriteLine("Error.");
            }
            else
            {
                Console.WriteLine("This pay rate is okay.");
            }
        }
    }
}
