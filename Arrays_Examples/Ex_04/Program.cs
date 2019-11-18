using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // November 15, 2019 - letting user enter values

            int[] tests;    // rule of thumb, when naming arrays it must be plural
            double average;
            int sum = 0;
            int numberOfTests;

            Console.WriteLine("How many test scores will you to enter?");
            numberOfTests = Convert.ToInt32(Console.ReadLine());

            tests = new int[numberOfTests];     // initializing the size of the array

            // collect all the test scores from the user
            for (int i = 0; i <numberOfTests; ++i)  // i for index
            {
                Console.Write($"What is the test score for test {i+1}: ");
                tests[i] = Convert.ToInt32(Console.ReadLine());
            }

            // printing all of the test scores and adding test scores
            for (int i = 0; i < numberOfTests; ++i)
            {
                Console.WriteLine($"Test {i+1} score is: {tests[i]}");
                sum += tests[i];
            }

            average = (double)sum / tests.Length;

            Console.WriteLine($"Average is {average}.");
        }
    }
}
