using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            /* Create a program that calculates and displays the average 
             * of three numbers. The user will enter the three numbers */

            double number1;
            double number2;
            double number3;
            const int NUMBER_OF_NUMBERS = 3;

            Console.WriteLine("Please enter 3 numbers:");
            Console.Write("Number 1: ");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number 2: ");
            number2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number 3: ");
            number3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The average of these numbers is: {(number1 + number2 + number3) / NUMBER_OF_NUMBERS}");
        }
    }
}
