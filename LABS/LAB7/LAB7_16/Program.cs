using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - November 1, 2019

            /* Write programs to output the following patterns. You must not hard-code the 
             * size of the figure. You should be able to output different sizes by changing 
             * the value of one or two variables.
             * ******* 
             * ****** *
             * ***** ** 
             * **** ***
             * *** ****
             * ** *****
             * * ******
             *  ******* */

            int columns = 8;
            int rows = 8;
            int counterRows = 0;
            int counterColumns = 0;
            int blankSpot = columns - 1;

            while (counterRows < rows)
            {
                while (counterColumns < columns)
                {
                    if (counterColumns == blankSpot)
                    {
                        Console.Write(" ");
                    }

                    else
                    {
                        Console.Write("*");
                    }

                    ++counterColumns;
                }
                counterColumns = 0;

                Console.WriteLine();

                ++counterRows;
                --blankSpot;
            }
        }
    }
}
