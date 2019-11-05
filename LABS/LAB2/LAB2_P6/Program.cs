using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_P6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            /* Willow Pools wants a program that allows its salespeople 
             * to enter the dimensions of a rectangular pool in meters. 
             * The program should display the volume of the rectangular 
             * pool. */

            double length;
            double width;
            double height;

            Console.WriteLine("Please enter the dimensions of the pool in meters below.");
            Console.Write("Length: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Width: ");
            width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The volume of the pool is {length * width * height} square meters.");
        }
    }
}
