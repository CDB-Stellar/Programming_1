using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB9_08
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - November 19, 2019

            /* The Chat-A-While phone company provides service to six area codes and charges the per-minute rates 
             * for phone calls shown in the accompanying table.
             * Area Code Per-   Minute Rate ($)
             * 262              0.07
             * 414              0.10
             * 608              0.05
             * 715              0.16
             * 815              0.24
             * 920              0.14
             * Write a program that allows a user to enter an area code and the length of time for a call in minutes, 
             * then display the total cost of the call. (use parrallel arrays) */

            int[] areaCodes = { 262, 414, 608, 715, 815, 920 };
            double[] minuteRates = { 0.07, 0.10, 0.05, 0.16, 0.24, 0.14 };
            int userAreaCode;
            int lengthOfCall;
            double minuteRate = 0;

            Console.WriteLine("Please enter an area code, and the length of the call below:");
            Console.Write("Area code: ");
            userAreaCode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Length of call in minutes: ");
            lengthOfCall = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < minuteRates.Length; ++i)
            {
                if (areaCodes[i] == userAreaCode)
                {
                    minuteRate = minuteRates[i];
                }
            }

            Console.WriteLine($"The total cost of the call is: {minuteRate * lengthOfCall:c}");
        }
    }
}
