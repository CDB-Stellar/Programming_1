using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8_21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - November 11, 2019

            /* Write a program to create the following figures:
             * (Draw top triangle (row 1 - 6), then draw bottom inverse triangle row (7 - 11))
             *  1      *            (top triangle rows - row number = blank space)
             *  2     ***           (stars in last row + 2 = stars in next row)
             *  3    *****
             *  4   *******
             *  5  *********
             *  6 *********** 
             *  7  *********        (blank spots in last line + 1 = blank spots in next line)
             *  8   *******
             *  9    *****
             * 10     ***
             * 11      *       */

            const int MAX_ROWS = 11;    // Must always be an odd number
            int topTriangleRows = (MAX_ROWS / 2) +1;
            string blankSpace = "";
            string stars = "*";

            // Printing the top triangle
            for (int rowNumber = 1; rowNumber <= topTriangleRows; ++rowNumber)
            {
                for (int blanks = 0; blanks < (topTriangleRows - rowNumber); ++blanks)
                {
                    blankSpace += " ";
                }
                Console.Write(blankSpace);
                Console.WriteLine(stars);
                blankSpace = "";
                stars += "**";
            }

            // Printing the bottom inverse triangle

        }
    }
}
