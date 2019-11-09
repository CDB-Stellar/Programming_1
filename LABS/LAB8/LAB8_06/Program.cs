using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8_06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - November 8, 2019

            /* Write a program that displays a conversion table from Fahrenheit to Celsius. The 
             * program must request the starting Fahrenheit value, the ending Fahrenheit value, 
             * and the increment. Thus, instead of the condition checking for a fixed count, 
             * the condition checks for the ending Fahrenheit value. */
             
            int end;
            int increment;
            int fahrenheight;
            double celsius;

            Console.WriteLine("Enter the starting and ending Fahrenheit values, and the increment value below:\n");
            Console.Write("Starting value: ");
            fahrenheight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ending value: ");
            end = Convert.ToInt32(Console.ReadLine());
            Console.Write("Increment value: ");
            increment = Convert.ToInt32(Console.ReadLine());

            while (fahrenheight <= end + 1)
            {
                celsius = (fahrenheight - 32) * 5 / 9;
                Console.WriteLine($"{fahrenheight} F°  =  {celsius} C°");
                fahrenheight += increment;
            }
        }
    }
}
