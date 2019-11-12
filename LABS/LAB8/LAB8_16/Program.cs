using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - November 11, 2019

            /* Write a program to create the following figures:
             * 1 *          (row number - 1 = blank space)
             * 2  *
             * 3   *
             * 4    *
             * 5     *
             * 6      *
             * 7       *  */

            const int MAX_ROWS = 7;
            string blankSpace = "";

            for (int rowNumber = 1; rowNumber <= MAX_ROWS; ++rowNumber)
            {
                for (int blank = 0; blank < (rowNumber - 1); ++blank)
                {
                    blankSpace += " ";
                }
                Console.Write(blankSpace);
                Console.WriteLine("*");
                blankSpace = "";
            }
        }
    }
}
