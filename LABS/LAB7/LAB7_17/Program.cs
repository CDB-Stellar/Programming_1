using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7_17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - November 8, 2019

            /* Write programs to output the following patterns. You must not hard-code the 
             * size of the figure. You should be able to output different sizes by changing
             * the value of one or two variables. 
             * (max rows - row number = number of blank spaces)
             * 1        *
             * 2       ***
             * 3      *****
             * 4     *******
             * 5    ********* 
             * 6   *********** 
             * 7  *************
             * 8 *************** */

            const int MAX_ROWS = 8;
            string blankSpace = "";

            for (int rowCount = 1; rowCount <= MAX_ROWS; ++rowCount)
            {
                for (int count = 0; count < (MAX_ROWS - rowCount); ++count)
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
