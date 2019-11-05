using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - November 1, 2019

            /* Write programs to output the following patterns. You must not hard-code the 
             * size of the figure. You should be able to output different sizes by changing 
             * the value of one or two variables.
             * ********
             *  ********
             *   ******** 
             *    ********
             *     ******** */

            int columns = 8;
            int rows = 5;
            int counterRows = 0;
            int counterColumns = 0;
            string blankSpace = " ";

            while (counterRows < rows)
            {
                while (counterColumns < columns)
                {
                    Console.Write("*");
                    ++counterColumns;
                }
                counterColumns = 0;

                Console.WriteLine();
                Console.Write(blankSpace);

                blankSpace = blankSpace + " ";
                ++counterRows;
            }
        }
    }
}
