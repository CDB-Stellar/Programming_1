using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6_P10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - October 24, 2019

            /* Write a program that prompts the user or an hourly pay rate. If 
             * the value entered is less than $5.65, display an error message. */

            const double LIMIT = 5.56;
            double hourlyPay;

            Console.Write("Please enter your hourly pay rate: $");
            hourlyPay = Convert.ToDouble(Console.ReadLine());

            if (hourlyPay < LIMIT)
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
