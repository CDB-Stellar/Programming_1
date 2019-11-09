using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7_19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - November 8, 2019

            /* Write programs to output the following patterns. You must not hard-code the 
             * size of the figure. You should be able to output different sizes by changing
             * the value of one or two variables. 
             * (make a triangle from row 1 - 5, and then a smaller one underneath - row 6 - 9)
             * (max rows - row number = number of blank spaces)
             * 1     * 
             * 2    ***
             * 3   *****
             * 4  *******
             * 5 *********
             * 6  *******
             * 7   *****
             * 8    ***
             * 9     *     */

            // Top triangle (row 1 - 5)
            const int MAX_ROWS_UPPER = 5;
            string blankSpace = "";

            for (int rowCount = 1; rowCount <= MAX_ROWS_UPPER; ++rowCount)
            {
                for (int count = 0; count < (MAX_ROWS_UPPER - rowCount); ++count)
                {
                    blankSpace += " ";
                }

                Console.Write(blankSpace);

                for (int colCount = 0; colCount < rowCount * 2 - 1; ++colCount)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                blankSpace = "";
            }

            // Bottom upside down triangle (row 6 - 9)
            for (int rowCount = MAX_ROWS_UPPER - 1; rowCount >= 1; --rowCount)
            {
                for (int count = 0; count < (MAX_ROWS_UPPER - rowCount); ++count)
                {
                    blankSpace += " ";
                }

                Console.Write(blankSpace);

                for (int colCount = 0; colCount < rowCount * 2 - 1; ++colCount)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                blankSpace = "";
            }
        }
    }
}
