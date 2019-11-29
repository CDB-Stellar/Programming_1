using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - November 29, 2019

            /* Write a method called CalculateAreaOfCircle(), that prompts the user for the radius 
             * of a circle and then calculates and displays the area [A = πr^2]. Call this method from main. */

            CalculateAreaOfCircle();
        }

        static void CalculateAreaOfCircle()
        {
            double radius;
            double area;

            Console.Write("Please enter the radius of the circle: ");
            radius = Convert.ToDouble(Console.ReadLine());
            area = (3.14 * radius) * (3.14 * radius);
            Console.WriteLine($"The area is: {area}");
        }
    }
}
