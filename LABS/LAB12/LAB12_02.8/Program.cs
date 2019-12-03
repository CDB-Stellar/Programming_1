using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_02._8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - December 2, 2019

            /* [Part 2: Question 8] 
             * Write a method that converts a person’s height from centimeter to meters and
             * centimeters and display the result on the console. In your main method, you 
             * should prompt the user for his height in cm and then call the method with 
             * this value. */

            int height;

            Console.Write("Enter your height in cm: ");
            height = Convert.ToInt32(Console.ReadLine());

            DisplayHeightInMeters(height);
        }

        static void DisplayHeightInMeters(int centimeters)
        {
            Console.WriteLine($"{centimeters} cm  =  {centimeters / 100} m {(double)centimeters % 100} cm");
        }
    }
}
