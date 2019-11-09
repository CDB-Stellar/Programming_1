using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7_18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - November 8, 2019

            /* Write programs to output the following patterns. You must not hard-code the 
             * size of the figure. You should be able to output different sizes by changing
             * the value of one or two variables. ((max rows * 2) - 3 = inner blank space)
             * 1 *         *9 = 6*2-3
             * 2  *       *7 = 5*2-3
             * 3   *     *5
             * 4    *   *3
             * 5     * *1
             * 6      *      */

            const int MAX_ROWS = 6;
            string blankSpace = "";
            string innerBlankSpace = "";
            int innerBlank = (MAX_ROWS * 2) - 3;

            for (int rowCount = 1; rowCount <= MAX_ROWS; ++rowCount)
            {
                for (int outerBlank = 0; outerBlank < (rowCount - 1); ++outerBlank)
                {
                    blankSpace += " ";
                    Console.Write(blankSpace);
                    blankSpace = "";
                }

                Console.Write("*");

                for (int blanks = 0; blanks < innerBlank; ++blanks) //the example technically has: blanks <= innerBlank; but i think that's a mistake
                {
                    blankSpace += " ";
                    Console.Write(blankSpace);
                    blankSpace = "";
                }

                Console.Write(innerBlankSpace);

                if (rowCount != MAX_ROWS)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                innerBlank -= 2;
            }
        }
    }
}
