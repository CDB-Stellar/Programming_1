using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_P5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            /* Tile Limited wants a program allows its salesclerk to enter 
             * the length and width (in meters) of a rectangle and the 
             * price of a square meter of tile. The program should display 
             * the area of the rectangle and the total cost of the tile. */

            double length;
            double width;
            double pricePerSquareMeter;

            Console.WriteLine("Please enter the length and width of the rectangle and the price per square meter of tile below:");
            Console.Write("Length: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Width: ");
            width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Price per square meter of tile: ");
            pricePerSquareMeter = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The area of the rectangle is: {length * width}.");
            Console.WriteLine($"The total cost of the tile is: {length * width * pricePerSquareMeter:c}.");
        }
    }
}
