using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6_P12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - October 24, 2019

            /* Write a program that prompts a user for an hourly pay rate. If 
             * the user enters values less than $5.65 or greater than $49.99, 
             * prompt the user again. If the user enters an invalid value 
             * again, display an appropriate error message. If the user enters 
             * a valid value on either the first or second attempt, display 
             * the pay rate as well as the weekly rate which calculated as 40 
             * times the hourly rate. */

            const double LOWER_LIMIT = 5.56;
            const double UPPER_LIMIT = 49.99;
            const int FULL_TIME_HOURS = 40;
            double hourlyPay;

            Console.Write("Please enter your hourly pay rate: $");
            hourlyPay = Convert.ToDouble(Console.ReadLine());

            if (hourlyPay < LOWER_LIMIT || hourlyPay > UPPER_LIMIT)
            {
                Console.Write("Please enter your hourly pay rate: $");
                hourlyPay = Convert.ToDouble(Console.ReadLine());

                if (hourlyPay < LOWER_LIMIT || hourlyPay > UPPER_LIMIT)
                {
                    Console.WriteLine("Error. Invalid pay rate.");
                }
                else
                {
                    Console.WriteLine($"Hourly Rate: {hourlyPay:c} \nWeekly Pay: {hourlyPay * FULL_TIME_HOURS:c}");
                }
            }
            else
            {
                Console.WriteLine($"Hourly Rate: {hourlyPay:c} \nWeekly Pay: {hourlyPay * FULL_TIME_HOURS:c}");
            }
        }
    }
}
