using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - November 29, 2019

            /* [Part 1: Question 4]
             * Write a method called CalculateAreaOfTriangle(), that prompts the user for the base and height 
             * of a triangle and then calculates and displays the area [A=bt/2]. Call this method from main. */

            CalculateAreaOfTriangle();
        }

        static void CalculateAreaOfTriangle()
        {
            double baseOfTriangle;
            double height;
            double area;

            Console.Write("Enter the base of the triangle: ");
            baseOfTriangle = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the height of the triangle: ");
            height = Convert.ToDouble(Console.ReadLine());
            area = baseOfTriangle * height / 2;
            Console.WriteLine($"The area of the triangle is: {area}");
        }
    }
}
