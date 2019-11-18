using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_05
{
    class Program
    {
        static void Main(string[] args)
        {
            // November 15, 2019 - Adding min and max test scores

            int[] tests;
            double average;
            int sum = 0;
            int numberOfTests;
            int min;
            int max;

            Console.WriteLine("How many test scores will you to enter?");
            numberOfTests = Convert.ToInt32(Console.ReadLine());

            tests = new int[numberOfTests];
            
            for (int i = 0; i < numberOfTests; ++i)
            {
                Console.Write($"What is the test score for test {i + 1}: ");
                tests[i] = Convert.ToInt32(Console.ReadLine());
            }

            min = tests[0];     // initialize your lowest and highest value as whatever the first value entered was
            max = tests[0];
            
            for (int i = 0; i < numberOfTests; ++i)
            {
                Console.WriteLine($"Test {i + 1} score is: {tests[i]}");
                sum += tests[i];

                if (tests[i] < min)     // changing min and max if necessary
                {
                    min = tests[i];
                }

                if (tests[i] > max)
                {
                    max = tests[i];
                }
            }

            average = (double)sum / tests.Length;

            Console.WriteLine($"\nThe average is {average:f2}.");
            Console.WriteLine($"\nMax score: {max} \nMin score: {min}");
        }
    }
}
