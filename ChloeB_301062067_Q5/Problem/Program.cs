using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067

            Console.WriteLine(CalculateDifference(1, 2));
            Console.WriteLine(CalculateDifference(5, 4));
            Console.WriteLine(CalculateDifference(4, 5));
            Console.WriteLine(CalculateDifference(10, -7));
        }

        static int CalculateDifference(int firstNumber, int secondNumber)
        {
            int difference;

            if (secondNumber < firstNumber)
                difference = firstNumber - secondNumber;
            else
                difference = secondNumber - firstNumber;

            return difference;
        }
    }
}
