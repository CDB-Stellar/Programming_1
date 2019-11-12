using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - November 11, 2019

            /* Write a program to create the following figures:
             * 1 -----*         (max rows - row number = dashes)
             * 2 ----***
             * 3 ---*****
             * 4 --*******
             * 5 -*********
             * 6 ***********  */

            const int MAX_ROWS = 6;
            string dashString = "";
            string starString = "*";

            for (int rowNumber = 1; rowNumber <= MAX_ROWS; ++rowNumber)
            {
                for (int dashes = 0; dashes < (MAX_ROWS - rowNumber); ++dashes)
                {
                    dashString += "-";
                }
                Console.Write(dashString);
                dashString = "";

                Console.WriteLine(starString);
                starString += "**";
            }
        }
    }
}
