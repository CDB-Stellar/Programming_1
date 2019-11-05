using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            /* Write a program to find the difference or sum of two numbers. The program 
             * should prompt for the operation and the two numbers. If the operation is “+” 
             * then the program should add the two numbers and display the sum, else the 
             * program should subtract the second number from the first and display the 
             * difference. */

            double firstNumber;
            double secondNumber;
            double result;
            string operation;

            Console.WriteLine("Which operation would you like to perform: ");
            operation = Console.ReadLine();

            Console.WriteLine("Please enter the first number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            if (operation == "+")
            {
                result = firstNumber + secondNumber;
                Console.WriteLine($"The sum is {result}.");
            }
            else
            {
                result = firstNumber - secondNumber;
                Console.WriteLine($"The difference is {result}.");
            }
        }
    }
}
