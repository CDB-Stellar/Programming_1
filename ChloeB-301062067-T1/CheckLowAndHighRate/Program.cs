using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLowAndHighRate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            double hourlyPay;
            const double LOWEST_RATE = 7.5;
            const double HIGHEST_RATE = 49.99;

            Console.WriteLine("Please enter your hourly pay rate: ");
            hourlyPay = Convert.ToDouble(Console.ReadLine());

            if (hourlyPay < LOWEST_RATE || hourlyPay > HIGHEST_RATE)
            {
                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine($"{hourlyPay:c} is ok.");
            }
        }
    }
}
