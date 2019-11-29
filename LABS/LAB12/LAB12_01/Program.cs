using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - November 29, 2019

            /* [Part 1: Question 1]
             * 1. Write a method called DisplayPersonalInfo() to display your name, school, program and your 
             * favorite course. Call this method from main. */

            DisplayPersonalInfo();
        }

        static void DisplayPersonalInfo()
        {
            Console.WriteLine($"{"Name:",18} Chloe Baker");
            Console.WriteLine($"{"School:",18} Centennial College");
            Console.WriteLine($"{"Program:",18} Game-Programming");
            Console.WriteLine($"{"Favourite Course:",18} Programming :)");
        }
    }
}
