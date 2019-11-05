using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6_P5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - October 24, 2019

            /* Write a program that prompts the user for a day of the week. The 
             * program will display a message based on the following table:
             * Choice       Message
             * Sun          "Home"
             * Mon          "Work"
             * Tue          "Work"
             * Wed          "Home"
             * Thu          "Work"
             * Fri          "Work"
             * Sat          "Work" */

            string dayOfWeek;

            Console.WriteLine("Please enter a day of the week (Example: \"Mon\")");
            dayOfWeek = Console.ReadLine();

            switch (dayOfWeek)
            {
                case "Mon":
                    Console.WriteLine("Home");
                    break;
                case "Tue":
                    Console.WriteLine("Work");
                    break;
                case "Wed":
                    Console.WriteLine("Work");
                    break;
                case "Thu":
                    Console.WriteLine("Home");
                    break;
                case "Fri":
                    Console.WriteLine("Work");
                    break;
                case "Sat":
                    Console.WriteLine("Work");
                    break;
                case "Sun":
                    Console.WriteLine("Work");
                    break;
                default:
                    Console.WriteLine("Invalid.");
                    break;
            }
        }
    }
}
