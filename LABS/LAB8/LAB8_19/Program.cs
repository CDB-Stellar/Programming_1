﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8_19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - November 11, 2019

            /* Write a program to create the following figures:
             * 1      ******        (max rows - row number = blank space)
             * 2     ******         (max rows = stars)
             * 3    ******
             * 4   ******
             * 5  ******
             * 6 ******  */

            const int MAX_ROWS = 6;
            string blankSpace = "";
            string stars = "";

            for (int rowNumber = 1; rowNumber <= MAX_ROWS; ++rowNumber)
            {
                for (int blank = 0; blank < (MAX_ROWS - rowNumber); ++blank)
                {
                    blankSpace += " ";
                }
                Console.Write(blankSpace);
                blankSpace = "";

                for (int count = 0; count < MAX_ROWS; ++count)
                {
                    stars += "*";
                }
                Console.WriteLine(stars);
                stars = "";
            }
        }
    }
}
