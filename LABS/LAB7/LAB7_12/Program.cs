using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - October 29, 2019

            /* Write programs to output the following patterns. You must not hard-code the 
             * size of the figure. You should be able to output different sizes by changing 
             * the value of one or two variables.
             * ********
             * ********
             * ******** */

            int columns = 8;
            int rows = 3;
            int counterRows = 0;
            int counterColumns = 0;

            while (counterRows < rows)
            {
                while (counterColumns < columns)
                {
                    Console.Write("*");
                    ++counterColumns;
                }
                counterColumns = 0;

                Console.WriteLine();

                ++counterRows;
            }
        }
    }
}
