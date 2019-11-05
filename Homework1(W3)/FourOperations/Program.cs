using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            float firstNumberSingle;
            float secondNumberSingle;
            string userInput;

            Console.WriteLine("Please enter two numbers you would like to evaluate.");
            Console.WriteLine("First number:");
            userInput = Console.ReadLine();
            firstNumber = Convert.ToInt32(userInput);

            Console.WriteLine("Second number:");
            userInput = Console.ReadLine();
            secondNumber = Convert.ToInt32(userInput);

            Console.Write(firstNumber);
            Console.Write(" + ");
            Console.Write(secondNumber);
            Console.Write(" = ");
            Console.WriteLine(firstNumber + secondNumber);

            Console.Write(firstNumber);
            Console.Write(" - ");
            Console.Write(secondNumber);
            Console.Write(" = ");
            Console.WriteLine(firstNumber - secondNumber);

            Console.Write(firstNumber);
            Console.Write(" * ");
            Console.Write(secondNumber);
            Console.Write(" = ");
            Console.WriteLine(firstNumber * secondNumber);

            firstNumberSingle = Convert.ToSingle(firstNumber);
            secondNumberSingle = Convert.ToSingle(secondNumber);

            Console.Write(firstNumber);
            Console.Write(" / ");
            Console.Write(secondNumber);
            Console.Write(" = ");
            Console.WriteLine(firstNumberSingle / secondNumberSingle);
        }
    }
}
