using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - October 24, 2019

            /* Write a program that prompts the user for a menu choice. The program 
             * will display a message based on the following table:
             * Choice           Message
             * 1                "Calculate area"
             * 2                "Calculate volume"
             * 3                "Calculate surface area"
             * 0                "Exit the program"
             * any other input  "ERROR: Invalid choice" */

            int userChoice;

            Console.Write("Please enter a number from 1 - 3, or 0 to exit the program: ");
            userChoice = Convert.ToInt32(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    Console.WriteLine("Calculate area");
                    break;
                case 2:
                    Console.WriteLine("Calculate volume");
                    break;
                case 3:
                    Console.WriteLine("Calculate surface area");
                    break;
                case 0:
                    Console.WriteLine("Exit the program");
                    break;
                default:
                    Console.WriteLine("ERROR: Invalid choice");
                    break;

            }
        }
    }
}
