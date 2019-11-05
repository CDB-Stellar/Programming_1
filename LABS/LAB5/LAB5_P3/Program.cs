using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_P3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            /* If money is left in a particular bank for more than 
             * 5 years, the interest rate given by the bank is 7.5%, 
             * else the interest rate is 5.4%. Write a program that prompts 
             * the user for the number of years that the money was left in 
             * the bank and display the appropriate interest rate depending on 
             * the value input. */

            int numberOfYears;
            const int MIN_YEARS = 5;

            Console.WriteLine("Please enter the number of years the money has been in the bank:");
            numberOfYears = Convert.ToInt32(Console.ReadLine());

            if (numberOfYears > MIN_YEARS)
            {
                Console.WriteLine("The interest rate is 7.5%.");
            }
            else
            {
                Console.WriteLine("The interest rate is 5.4%.");
            }
        }
    }
}
