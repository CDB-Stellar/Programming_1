using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_P4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            /* Write a console-based program that prompts a user for an 
             * hourly pay rate. If the user enters values less than $7.50 
             * or greater than $49.99, prompt the user again. If the user 
             * enters an invalid value again, display an appropriate error 
             * message. If the user enters a valid value on either the first 
             * or second attempt, display the pay rate as well as the weekly 
             * rate, which is calculated as 40 times the hourly rate. */

            double hourlyPay;
            const double MIN_PAY_RATE = 7.5;
            const double MAX_PAY_RATE = 49.99;

            Console.Write("Please enter your hourly pay rate: $");
            hourlyPay = Convert.ToDouble(Console.ReadLine());

            if (hourlyPay < MIN_PAY_RATE || hourlyPay > MAX_PAY_RATE)
            {
                Console.Write("Please enter your hourly pay rate: $");
                hourlyPay = Convert.ToDouble(Console.ReadLine());

                if (hourlyPay < MIN_PAY_RATE || hourlyPay > MAX_PAY_RATE)
                {
                    Console.WriteLine("Error.");
                }
                else
                {
                    Console.WriteLine($"Hourly pay: {hourlyPay:c} \nWeekly pay: {hourlyPay * 40:c}");
                }
            }
            else
            {
                Console.WriteLine($"Hourly pay: {hourlyPay:c} \nWeekly pay: {hourlyPay * 40:c}");
            }
        }
    }
}
