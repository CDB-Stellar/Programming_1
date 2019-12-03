using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_03._7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - December 2, 2019

            /* [Part 3: Question 7]
             * Heron’s formula allows you to calculate the area of any triangle given the length of the
             * three sides. Write a method that takes the length of the three sides and return the area
             * of the specified triangle. A=√s(s−a)(s−b)(s−c) where s=a+b+c/2. */

            Console.WriteLine(CalculateAreaOfTriangle(4f,5f,6f));
        }

        static double CalculateAreaOfTriangle(double sideA, double sideB, double sideC)
        {
            double semiPerimeter = (sideA + sideB + sideC) / 2f;
            double area = Math.Sqrt((semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC)));
            return area;
        }
    }
}
