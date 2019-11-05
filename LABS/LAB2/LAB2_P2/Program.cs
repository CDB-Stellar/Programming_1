using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_P2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            /* Perry Brown needs a program that allows him to enter the 
             * length of fours sides of a polygon. The program should 
             * display the perimeter of the polygon. */

            double side1;
            double side2;
            double side3;
            double side4;

            Console.WriteLine("Please enter the four sides of the polygon below:");
            Console.Write("Side 1: ");
            side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side 2: ");
            side2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side 3: ");
            side3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side 4: ");
            side4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The perimeter of the polygon is {side1 + side2 + side3 + side4}");
        }
    }
}
