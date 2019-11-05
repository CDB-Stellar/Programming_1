using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_03_Numbers_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            int firstNumber;
            int secondNumber;
            string userInput;

            Console.WriteLine("Please enter two numbers you would like to add.");

            Console.WriteLine("What is the first number?");
            userInput = Console.ReadLine();
            firstNumber = Convert.ToInt32(userInput);

            Console.WriteLine("What is the second number?");
            userInput = Console.ReadLine();
            secondNumber = Convert.ToInt32(userInput);

            Console.Write(firstNumber);
            Console.Write("+");
            Console.Write(secondNumber);
            Console.Write("=");
            Console.WriteLine(firstNumber + secondNumber);
        }
    }
}
