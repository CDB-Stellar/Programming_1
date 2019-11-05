using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6_P2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - October 24, 2019

            /* Write a program that allows the user to enter two integers and a character. 
             * If the character is A, add the two integers. If it is S, subtract the second 
             * integer from the first. If it is M, multiply the integers. Display the 
             * results of the arithmetic. */

            int number1;
            int number2;
            char operation;

            Console.WriteLine("Please enter 2 integers and the operation to perform as a letter ('A'dd, 'S'ubtract, 'M'ultiply)");
            Console.Write("First number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Operation: ");
            operation = Convert.ToChar(Console.ReadLine());

            switch (operation)
            {
                case 'A':
                    Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
                    break;
                case 'S':
                    Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
                    break;
                case 'M':
                    Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
                    break;
                default:
                    Console.WriteLine("Invalid.");
                    break;
            }
        }
    }
}
