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
            //Chloe Baker - 301062067 - November 1, 2019

            /* Write programs to output the following patterns. You must not hard-code the 
             * size of the figure. You should be able to output different sizes by changing 
             * the value of one or two variables. (max rows - row number = number of spaces)
             * 1        *
             * 2       ***
             * 3      *****
             * 4     *******
             * 5    ********* 
             * 6   *********** 
             * 7  *************
             * 8 *************** */

            const int MAX_ROWS = 8;
            int rowNumber = 1;

            for (int rowCount = 0; rowCount < MAX_ROWS; ++rowCount)
            {
                
            }

            //const int TRIANGLE_BASE = 15;
            //string blankSpace = "";
            //int blankStringLength = (TRIANGLE_BASE - 1)/2;
            //string stars = "*";
            //int rowSize = 1;

            ////Initializing amount of blank space
            //while (blankSpace.Length < blankStringLength)
            //{
            //    blankSpace += " ";
            //}

            //while (rowSize <= TRIANGLE_BASE)
            //{
            //    Console.Write($"{blankSpace}{stars}");
            //    Console.WriteLine();
            //    stars += "**";
            //    --blankStringLength;
            //    blankSpace = blankSpace.Substring(0, blankStringLength);

            //    ++rowSize;
            //}
        }
    }
}
