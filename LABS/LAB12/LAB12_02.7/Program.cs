using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_02._7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - December 2, 2019

            /* [Part 2: Question 7] 
             * Modify the DisplaySineTable in the previous section to accept the start value, the step
             * size and number of rows as argument to the method. */

            DisplaySineTable(1f, 1f, 3);
            DisplaySineTable(10f, 2f, 3);
            DisplaySineTable(1.2f, 0.2, 3);
        }

        static void DisplaySineTable(double startValue, double stepSize, int rows)
        {
            for (int count = 0; count < rows; ++count)
            {
                Console.WriteLine($"{startValue,4:f2}     {Math.Sin(startValue),6:f4}");
                startValue += stepSize;
            }
        }
    }
}
