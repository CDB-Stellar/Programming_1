using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_P4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            /* Builders’s Inc. needs a program that allows its salesclerks 
             * to enter the diameter of a circle and the prices of railing 
             * material per foot. The program should display the 
             * circumference of the circle and total price of the railing 
             * material. (Use 3.14 as the value of pi) */

            double diameter;
            double railingMaterialPrice;

            Console.WriteLine("Please enter the diameter of the circle and the prices of railing material per foot.");
            Console.Write("Diameter in feet: ");
            diameter = Convert.ToDouble(Console.ReadLine());
            Console.Write("Price of railing material per foot: ");
            railingMaterialPrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The circumference of the circle is {3.14 * diameter}.");
            Console.WriteLine($"The total price of railing is {3.14 * diameter * railingMaterialPrice:c}.");
        }
    }
}
