using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - November 29, 2019

            /* [Part 1: Question 6]
             * Write a method called DisplaySineTable(), that prompts the user for a starting value 
             * and an step size. Method will calculate and display a table (10 rows) of sine values based 
             * on the user input. Use the built-in method Math.Sin() to obtain the sine of an angle. 
             * Ex. if the starting value is 0.5 and the step size is 0.03 the method will display the following table:
             * 0.50     0.4794
             * 0.53     0.5055
             * 0.56     0.5311
             * ...
             * 0.77     0.6961      The numbers in both columns MUST be right aligned. */

            DisplaySineTable();
        }

        static void DisplaySineTable()
        {
            double startValue;
            double stepSize;

            Console.Write("Enter the starting value: ");
            startValue = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the step value: ");
            stepSize = Convert.ToDouble(Console.ReadLine());

            for (int count = 0; count < 10; ++count)
            {
                Console.WriteLine($"{startValue,4:f2}     {Math.Sin(startValue),6:f4}");
                startValue += stepSize;
            }
        }
    }
}
