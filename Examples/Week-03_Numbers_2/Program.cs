using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_03_Numbers_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            string firstNumber;
            string secondNumber;

            Console.WriteLine("Please enter two numbers you would like to add.");
            Console.WriteLine("What is the first number?");
            firstNumber = Console.ReadLine();
            Console.WriteLine("What is the second number?");
            secondNumber = Console.ReadLine();

            Console.Write(firstNumber);
            Console.Write("+");
            Console.Write(secondNumber);
            Console.Write("=");
            Console.WriteLine(firstNumber + secondNumber);
        }
    }
}
