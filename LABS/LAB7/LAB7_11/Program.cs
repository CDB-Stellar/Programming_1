using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - October 29, 2019

            /* A machine purchased for $28,000 is depreciated at a rate of $4,000 a year for 
             * seven years. Write and run a C# program that computes and displays a depreciation 
             * table for seven years, The table should have the form: 
             *                                  END-OF-YEAR          ACCUMULATED 
             * YEAR         DEPRECIATION           VALUE            DEPRECIATION
             * ----         ------------         ------------       ------------
             *  1               4000              24000                 4000
             *  2               4000              20000                 8000
             *  3               4000              16000                12000
             *  4               4000              12000                16000
             *  5               4000               8000                20000
             *  6               4000               4000                24000
             *  7               4000                  0                28000       */

            const int DEPRECIATION_RATE = 4000;
            int counter = 1;
            int endYearValue = 24000;
            int accumulatedDepreciation = 4000;

            Console.WriteLine("                                 END-OF-YEAR          ACCUMULATED");
            Console.WriteLine("YEAR         DEPRECIATION           VALUE            DEPRECIATION");
            Console.WriteLine("----         ------------         ------------       ------------");
            do
            {
                Console.WriteLine($" {counter,-16}{DEPRECIATION_RATE,-18}{endYearValue,5}                {accumulatedDepreciation,5}");
                endYearValue -= DEPRECIATION_RATE;
                accumulatedDepreciation += DEPRECIATION_RATE;
                counter++;
            } while (counter <= 7);
        }
    }
}
