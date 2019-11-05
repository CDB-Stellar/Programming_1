using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6_P8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - October 24, 2019

            /* Write a program for a furniture company. Ask the user to choose 
             * Pine, Oak, or Mahogany. Show the price of a table manufactured with 
             * the chosen wood. Pine tables cost $100, Oak tables cost $225, and 
             * Mahogany tables cost $310. Use named constants and switch. */

            const int PINE = 100;
            const int OAK = 225;
            const int MAHOGANY = 310;
            char userWoodChoice;

            Console.WriteLine("Please choose between Pine, Oak, or Mahogany below:");
            Console.Write("('P' / 'O' / 'M'): ");
            userWoodChoice = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (userWoodChoice)
            {
                case 'P':
                    Console.WriteLine($"A Pine table will cost {PINE:c}");
                    break;
                case 'O':
                    Console.WriteLine($"An Oak table will cost {OAK:c}");
                    break;
                case 'M':
                    Console.WriteLine($"A Mahogany table will cost {MAHOGANY:c}");
                    break;
                default:
                    Console.WriteLine("Invalid wood choice.");
                    break;
            }
        }
    }
}
