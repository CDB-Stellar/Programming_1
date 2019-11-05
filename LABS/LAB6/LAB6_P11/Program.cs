using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6_P11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - October 24, 2019

            /* Write a program that prompts a user for an hourly pay rate. If 
             * the value entered is less than $5.65 or greater than $49.99, 
             * display an error message. */

            const double LOWER_LIMIT = 5.56;
            const double UPPER_LIMIT = 49.99;
            double hourlyPay;

            Console.Write("Please enter your hourly pay rate: $");
            hourlyPay = Convert.ToDouble(Console.ReadLine());

            if (hourlyPay < LOWER_LIMIT || hourlyPay > UPPER_LIMIT)
            {
                Console.WriteLine("Error. Invalid pay rate.");
            }
            else
            {
                Console.WriteLine("This is an acceptable pay rate.");
            }
        }
    }
}
