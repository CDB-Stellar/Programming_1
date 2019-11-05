using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            double testOne;
            double testTwo;
            double testThree;
            double testFour;
            double testFive;
            double testAverage;
            const int NUMBER_OF_TESTS = 5;

            Console.WriteLine("Please enter five test scores.");

            Console.WriteLine("Test 1 score:");
            testOne = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Test 2 score:");
            testTwo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Test 3 score:");
            testThree = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Test 4 score:");
            testFour = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Test 5 score:");
            testFive = Convert.ToDouble(Console.ReadLine());

            testAverage = (testOne + testTwo + testThree + testFour + testFive) / NUMBER_OF_TESTS;

            Console.WriteLine($"The average of your test scores is: {testAverage:f2}.");

        }
    }
}
